using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerSide
{
    class HandleClient
    {
        Socket clientSocket;
        string clNo;
        public void startClient(Socket inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(go);
            ctThread.Start();
        }
        private void go()
        {
            // Incoming data from the client.    
            string data = null;
            byte[] bytes = null;
            bytes = new byte[1024];

            try
            {
                while (true)
                {
                    bytes.Clone();
                    int bytesRec = clientSocket.Receive(bytes);
                    data = Encoding.UTF8.GetString(bytes, 0, bytesRec); 
                    string[] str= data.Split(',');
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                   
                    switch (str[0]) 
                        //בודקת האם השאלה או החזרה
                    {
                        case "1":
                            //אם השאלה
                            switch (str[1])
                                //בודקת את מספר הספר
                            {
                                case "1":
                                    BookManagment.Lend(clientSocket, 1);
                                    break;
                                case "2":
                                    BookManagment.Lend(clientSocket, 2);
                                    break;
                                case "3":
                                    BookManagment.Lend(clientSocket, 3);
                                    break;
                                case "4":
                                    BookManagment.Lend(clientSocket, 4);
                                    break;
                                case "5":
                                    BookManagment.Lend(clientSocket, 5);
                                    break;
                                case "6":
                                    BookManagment.Lend(clientSocket, 6);
                                    break;
                            }
                            break;
                        case "0":
                            //אם החזרה של ספר
                            BookManagment.Return(clientSocket,Convert.ToInt32( str[1]));
                            break;
                    }                                               
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" >> " + ex.ToString());
            }
            finally
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            
        }
    }
}
