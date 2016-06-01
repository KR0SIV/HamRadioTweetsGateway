using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamRadioTweetsGateway
{
    class Parse
    {
        public void Ack(String message)
        {
            String Stripped = message.Substring(message.IndexOf('{') +1 );
            Console.WriteLine("Debug ACK Response: " + Stripped);
        }
    }
}
