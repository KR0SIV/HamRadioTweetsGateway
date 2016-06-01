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
            String Stripped = message.Substring(message.IndexOf('{') +1 ); // Parses the variable 'message' and removes everything up to the index of '{'. To remove that char we add +1
                                                                           // it is then assgined to the var 'Stripped'
            Console.WriteLine("Debug ACK Response: " + Stripped);
        }
    }
}
