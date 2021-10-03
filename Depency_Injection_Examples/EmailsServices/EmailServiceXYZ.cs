using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depency_Injection_Examples
{
    class EmailServiceXYZ : IServiceEmail
    {
        public EmailServiceXYZ() { }

        public void SendEmail(string content)
        {
            Console.WriteLine(new { Content = content }.ToString());
        }
    }
}
