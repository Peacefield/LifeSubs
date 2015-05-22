using NAudio.Wave;
using NAudio.Gui;
using NAudio.Utils;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LifeSubsMetro
{
    class MicLevelListener
    {
        public int deviceNumber { get; set; }
        public string noiseLevel { get; set; }
        public int sec { get; set; }
        WaveIn waveIn;
        Subtitle subtitleForm = null;
        SettingsMenu settingsMenu = null;
        //Thread act;
        Boolean canSend = false;
        int count = 0;

        Settings settings = new Settings();

        public MicLevelListener(Subtitle f)
        {
            this.subtitleForm = f;
            this.sec = settings.delay * 10;
        }

        public MicLevelListener(SettingsMenu f)
        {
            this.settingsMenu = f;
            this.sec = settings.delay * 10;
        }

        public void listenToStream()
        {
            //Get all microphones
            int waveInDevices = WaveIn.DeviceCount;
            //loop through array with microphones
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Console.WriteLine("Device {0}: {1}, {2} channels",
                    waveInDevice, deviceInfo.ProductName, deviceInfo.Channels);
            }

            //new WaveIn object
            waveIn = new WaveIn();

            //set microphone
            waveIn.DeviceNumber = deviceNumber;

            //check if data is being recorded and set the properties of the waveIn object
            waveIn.DataAvailable += waveIn_DataAvailable;
            int sampleRate = 8000; // 8 kHz
            int channels = 1; // mono
            waveIn.WaveFormat = new WaveFormat(sampleRate, channels);

            //Start recording
            waveIn.StartRecording();
        }

        public void stop()
        {
            waveIn.StopRecording();
        }

        private void countLowVoiceLevelBits(int i)
        {
            int min = -5;
            int max = 5;

            switch (noiseLevel)
            {
                case "Luidruchtig": 
                    min = -10;
                    max = 10;
                    break;
                case "Normaal":
                    min = -20;
                    max = 20;
                    break;
                case "Rustig":
                    min = -30;
                    max = 30;
                    break;
            }

            //1 increment is 1/10th of a second
            //Check if the sound level is between min and max, which means speaker is silent
            //if ((i < max) || (i < min))
            if (i < max && i > min)
            {
                //If the sound level is low enough, add 1 to the count variable
                count++;

                if (subtitleForm != null)
                {
                    subtitleForm.setVolumeMeter(i);
                    subtitleForm.setSendNoti(Color.SkyBlue);
                    subtitleForm.setLabel("STIL");
                }
                if (settingsMenu != null) settingsMenu.setVolumeMeter(i);
            }
            // Sound level is not between min and max, which means speaker is talking
            else 
            {
                //Console.WriteLine("GELUID");
                if (subtitleForm != null)
                {
                    subtitleForm.setSendNoti(Color.Green);
                    subtitleForm.setLabel("GELUID");
                }
                //Count variable should be set to 0
                canSend = true;
                count = 0;
            }
            //If no sound has been recorded for ... seconds, send audio to server
            if (count > sec)
            {
                if (subtitleForm != null)
                {
                    count = 0;
                    if (canSend)
                    {
                        //HTTP request has to be sent from here!!
                        //Count variable should be set to 0
                        canSend = false;
                        //Console.WriteLine("<<<<<<<<< Kan sturen >>>>>>>>>>>>");

                        subtitleForm.setSendNoti(Color.Red);
                        subtitleForm.setLabel("send");
                    }
                    else
                    {
                        subtitleForm.setSendNoti(Color.Yellow);
                        subtitleForm.setLabel("leeg");
                    }
                }
            }
        }

        private void actThing(object sender, WaveInEventArgs e)
        {
            //Loop through the received bytes
            for (int index = 0; index < e.BytesRecorded; index += 2)
            {
                //Convert the received bytes into a 32bit float
                short sample = (short)((e.Buffer[index + 1] << 8) |
                                        e.Buffer[index + 0]);
                float sample32 = sample / 32768f;

                //Multiply the 32bit float with 100 and convert it into an integer
                //so that calculating will be easier
                int test = (int)(sample32 * 100);

                //pass the test to the function that listens to sound
                countLowVoiceLevelBits(test);

                //We only want the first byte from the array, so the loop can be cut off 
                break;
            }
        }

        public void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            //Put the functions on another thread, so the GUI will not freeze
            //act = new Thread(() => actThing(sender, e));
            //act.Start();
            new Thread(() => actThing(sender, e)).Start();
        }
    }
}
