using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depency_Injection_Examples
{
    class UserExample
    {
        private IServiceEmail _serviceEmail;

        public IServiceEmail serviceEmail;

        public UserExample() { }

        public UserExample(IServiceEmail serviceEmail)
        {
            this._serviceEmail = serviceEmail;
        }

        public void SendEmail()
        {
            string content = "\nConstrutor Injection";
            this._serviceEmail.SendEmail(content);
        }

        public void SendEmail(IServiceEmail serviceEmail, string content)
        {
            serviceEmail.SendEmail(content);
        }

        public void SendEmail(string content)
        {
            this.serviceEmail.SendEmail(content);
        }

    }
}
