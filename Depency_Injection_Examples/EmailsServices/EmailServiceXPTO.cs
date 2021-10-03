using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depency_Injection_Examples
{
    class EmailServiceXPTO : IServiceEmail
    {
        public EmailServiceXPTO() { }

        public void SendEmail(string content)
        {
            Console.WriteLine(content);
        }
    }
}
