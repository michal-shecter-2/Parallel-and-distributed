using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;



namespace ServerSide
{
    static class BookManagment
    {
        static int[] books = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

        public static void Lend(Socket clientSocket, int numBook)
        {
            lock ("key")
            {
                if (books[numBook] == 1)
            {
                byte[] msg = Encoding.UTF8.GetBytes("הספר בהשאלה");
                int bytesSent = clientSocket.Send(msg);

            }

            else
            {
                
                    books[numBook] = 1;
                    byte[] msg = Encoding.UTF8.GetBytes("הספר בידך,קריאה נעימה");

                    // Send the data through the socket.    
                    int bytesSent = clientSocket.Send(msg);
                }
            }

        }

        internal static void Return(Socket clientSocket, int numBook)
        {
            lock ("key")
            {
                books[numBook] = 0;
                byte[] msg = Encoding.UTF8.GetBytes("תודה, מקווים שנהנת");

                // Send the data through the socket.    
                int bytesSent = clientSocket.Send(msg);
            }
        }

    }
}
