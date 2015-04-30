﻿using NAudio.Wave;
using System;
using System.IO;
using System.Net;

namespace LifeSubsMetro
{
    class Listener
    {
        string fileName;
        int deviceNumber = 0;
        Subtitle subtitleForm;

        public Listener(int deviceNumber, string fileName, Subtitle subtitleForm)
        {
            this.subtitleForm = subtitleForm;
            this.deviceNumber = deviceNumber;
            this.fileName = "C:\\audiotest\\" + fileName + ".wav";
        }

        //request with hardcoded file location to sent to dragon server
        //returns into textBox1
        public void request()
        {
            //form.setResult("request started: " + fileName);

            Console.WriteLine("request started: " + fileName);
            //form.setResult("request started: " + fileName);
            string result;
            try
            {
                //form.setResult("Trying " + fileName);
                string appId = "NMDPTRIAL_LifeSubs20150407091730";
                string appKey = "D1136D6CE6C9EFD586766EF8C74657655264C88513056C1616EBCD9245933416A6A1828D6A7262F0E8D0E8AF163F1468A4DDEDB7E259CDF9459A8B8A2EBFA0D4";
                string id = "57349abcd2390";
                //byte[] data = ReadFile(file);
                byte[] data = null;


                using (WaveFileReader reader = new WaveFileReader(fileName))
                {
                    //Assert.AreEqual(16, reader.WaveFormat.BitsPerSample, "Only works with 16 bit audio");

                    byte[] buffer = new byte[reader.Length];
                    int read = reader.Read(buffer, 0, buffer.Length);
                    short[] sampleBuffer = new short[read / 2];
                    Buffer.BlockCopy(buffer, 0, sampleBuffer, 0, read);
                    data = buffer;
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dictation.nuancemobility.net/NMDPAsrCmdServlet/dictation?appId=" + appId + "&appKey=" + appKey + "&id=" + id);

                request.Method = "POST";
                request.ContentType = "audio/x-wav;codec=pcm;bit=16;rate=16000";
                request.Accept = "text/plain";
                request.SendChunked = true;

                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "nld-NLD");
                //request.Headers.Add(HttpRequestHeader.AcceptLanguage, "eng-USA");
                request.Headers.Add("Accept-Topic", "Dictation");
                request.Headers.Add("X-Dictation-NBestListSize", "1");

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                //StreamReader sr = new StreamReader((Stream)sourceStream);

                result = sr.ReadToEnd();

                sr.Close();
                stream.Close();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        if ((int)response.StatusCode == 500)
                        {
                            Console.WriteLine("HTTP Status Code: " + (int)response.StatusCode);
                            //result = "500 internal server error: No match found";
                            result = "";
                        }
                        else
                        {
                            Console.WriteLine("HTTP Status Code: " + (int)response.StatusCode);
                            //result = "HTTP Status Code: " + (int)response.StatusCode;
                            result = "";
                        }
                    }
                    else
                    {
                        // no http status code available
                        Console.WriteLine("ProtocolError: " + ex.Status);
                        //result = "ProtocolError: " + ex.Status;
                        result = "";
                    }
                }
                else
                {
                    // no http status code available
                    Console.WriteLine(ex.Status.ToString());
                    result = "";
                }
            }
            Console.WriteLine(result);
            subtitleForm.setResult(result);
            //return result;
        }

        public void startRecording()
        {
            //form.setResult("Start Recording: " + fileName);
            Console.WriteLine("Start recording: " + fileName);

            //Start audio
            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(8000, 16, 2);
            //sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(16000, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(fileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
        }

        //Set NAudio variables
        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;

        //Write audio to sourceStream
        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        public void stop()
        {
            //form.setResult("Stop Recording: " + fileName);

            Console.WriteLine("Stop recording: " + fileName);

            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                //sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
        }
    }
}