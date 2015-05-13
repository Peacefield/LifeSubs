using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LifeSubsMetro
{
    class UdpListener
    {
        IPAddress ipAdr;
        int sendPort;
        bool done = false;
        UdpClient listener;
        IPEndPoint groupEP;
        string receivedData;
        byte[] receive_byte_array;
        Thread th;

		public UdpListener(int port, string ip)
        {
            this.ipAdr = IPAddress.Parse(ip);
            this.sendPort = port;
            th = new Thread(listen);
            th.Start();

        }

		public void listen()
        {
			try
			{
			while (true)
			{
                listener = new UdpClient(sendPort);
                groupEP = new IPEndPoint(IPAddress.Any, sendPort);
                Console.WriteLine("Waiting for broadcast");
			    // this is the line of code that receives the broadcase message.
			    // It calls the receive function from the object listener (class UdpClient)
			    // It passes to listener the end point groupEP.
			    // It puts the data from the broadcast message into the byte array
			    // named received_byte_array.
			    // I don't know why this uses the class UdpClient and IPEndPoint like this.
			    // Contrast this with the talker code. It does not pass by reference.
			    // Note that this is a synchronous or blocking call.
			    receive_byte_array = listener.Receive(ref groupEP);
                Console.WriteLine("NA receive_byte_array");
			    Console.WriteLine("Received a broadcast from {0}", groupEP.ToString() );
                Console.WriteLine("NA groupEP.ToString()");
			    receivedData = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                Console.WriteLine("NA receivedData = Encoding");
                Console.WriteLine(receive_byte_array);
			    Console.WriteLine("data follows \n{0}\n\n", receivedData);
			}
			}
			catch (Exception e)
			{
			    Console.WriteLine(e.ToString());
			}
			    listener.Close();
			}
        }
    }

