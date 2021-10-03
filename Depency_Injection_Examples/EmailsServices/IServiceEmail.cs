using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depency_Injection_Examples
{
    interface IServiceEmail
    {
        public void SendEmail(string content);
    }
}
