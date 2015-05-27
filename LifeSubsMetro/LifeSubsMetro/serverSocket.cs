using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LifeSubsMetro
{
    public class ServerSocket
    {
        static TcpListener tcpListener;
        public ServerSocket(MainMenu mm)
        {
            try
            {
                createServer();
            }
            catch (SocketException)
            {
                MetroFramework.MetroMessageBox.Show(mm, "Er is al een kamer actief", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            } 
        }

        public void createServer()
        {
            IPAddress ipaddress = IPAddress.Parse(getOwnIp());
            tcpListener = new TcpListener(ipaddress, 10);
            tcpListener.Start();
            Console.WriteLine("************This is Server program************");
            //Console.WriteLine("Hoe many clients are going to connect to this server?:");
            //int numberOfClientsYouNeedToConnect = int.Parse(Console.ReadLine());
            int numberOfClientsYouNeedToConnect = 50;
            for (int i = 0; i < numberOfClientsYouNeedToConnect; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }
        }

        private string getOwnIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            Console.WriteLine(host);

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private static void Listeners()
        {
            //Console.WriteLine("listener aangemaakt");
            try
            {
                
            Socket socketForClient = tcpListener.AcceptSocket();
            if (socketForClient.Connected)
            {
                Console.WriteLine("Client:" + socketForClient.RemoteEndPoint + " now connected to server.");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                System.IO.StreamWriter streamWriter =
                    new System.IO.StreamWriter(networkStream);
                System.IO.StreamReader streamReader =
                    new System.IO.StreamReader(networkStream);

                ////here we send message to client
                //Console.WriteLine("type your message to be recieved by client:");
                //string theString = Console.ReadLine();
                //streamWriter.WriteLine(theString);
                ////Console.WriteLine(theString);
                //streamWriter.Flush();

                //while (true)
                //{
                //here we recieve client's text if any.
                while (true)
                {
                    string theString = streamReader.ReadLine();
                    Console.WriteLine("Message recieved by " + socketForClient.RemoteEndPoint + " : " + theString);

                    if (theString == "exit")
                    {
                        Console.WriteLine(socketForClient.RemoteEndPoint + " left");
                        break;
                    }
                }
                streamReader.Close();
                networkStream.Close();
                streamWriter.Close();
                //}
            }
            socketForClient.Close();
            }
            catch (SocketException)
            {
                Console.WriteLine("Afgesloten");
            }
        }

        public void Destroy()
        {
            tcpListener.Stop();
            Thread.Sleep(1); //To prevent black screen
        }
    }
}
