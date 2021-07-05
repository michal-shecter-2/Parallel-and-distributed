using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{

    public partial class Form1 : Form
    {
         IPHostEntry host;
         IPAddress ipAddress;
         IPEndPoint remoteEP;
         Socket socket;
        //משתנה אסקי ששולח את הנתונים בסוקט
        byte[] bytes = new byte[1024];
      
        public  void StartClient()
        {

            try
            {
                 
                host = Dns.GetHostEntry("localhost");
                ipAddress = host.AddressList[0];
                remoteEP = new IPEndPoint(ipAddress, 3000);

                socket = new Socket(ipAddress.AddressFamily,SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.    
                try
                {
                    // Connect to Remote EndPoint  
                    socket.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",socket.RemoteEndPoint.ToString());

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }




        public Form1()
        {

            InitializeComponent();
            StartClient();
        }

               
        private void delete_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("1,2");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void BTM_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("1,1");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);

          
            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // socket.Shutdown(SocketShutdown.Both);
           // socket.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("0,2");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("0,1");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("0,3");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("0,4");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("0,5");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("0,6");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("1,3");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("1,4");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("1,5");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("1,6");

            // Send the data through the socket.    
            int bytesSent = socket.Send(msg);

            // Receive the response from the remote device.    
            int bytesRec = socket.Receive(bytes);
            String s = Encoding.UTF8.GetString(bytes, 0, bytesRec);


            // Displays the MessageBox.
            MessageBox.Show(s);
        }
    }
}
