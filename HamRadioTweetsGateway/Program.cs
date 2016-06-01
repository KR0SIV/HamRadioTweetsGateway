using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace HamRadioTweetsGateway
{
    class Program
    {

        public static void Initialize()
        {
            TcpClient client = new TcpClient("second.aprs.net", 20157);

            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());

            sw.WriteLine("user KR0SIV pass 16821");
            sw.Flush();
            

            new Thread(() => //creates a new thread that will read data and print it to the screen
            {
                string data = sr.ReadLine();
                while (data != null) //while data is not equal to null do the following
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                client.Close();
            }).Start();


/*
            new Thread(() =>
            {

                String input = Console.ReadLine();
                sw.WriteLine(input);
                sw.Flush();


            }).Start();
*/

//Below is a valid APRS packet
//            sw.WriteLine("KR0SIV>APRS,TCPIP*,qAC,NINTH::TWITR    :Sent from CSharp Code");
//            sw.Flush();

        }

        

        static void Main(string[] args)
        {
            // Initialize();
            Parse Parser = new Parse();
            Parser.Ack("KR0SIV>APRS,TCPIP*,qAC,EIGHTH::WB5OD    :Testing what an ack should look like{5"); //calling Parser.Ack to parse the data and grab whats need for an ACK
            Console.ReadLine();
        }
    }
}
