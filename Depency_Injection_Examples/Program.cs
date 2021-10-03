using System;

namespace Depency_Injection_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Injeção de Dependência
            IServiceEmail serviceEmail;
            UserExample userExample;

            #region Setter Injection
            serviceEmail = new EmailServiceXPTO();
            userExample = new UserExample();
            userExample.serviceEmail = serviceEmail;
            userExample.SendEmail("\nSetter Injection");

            serviceEmail = new EmailServiceXYZ();
            userExample = new UserExample();
            userExample.serviceEmail = serviceEmail;
            userExample.SendEmail("\nSetter Injection");
            #endregion 


            #region Constructor Injection
            serviceEmail = new EmailServiceXPTO();
            userExample = new UserExample(serviceEmail); 
            userExample.SendEmail();

            serviceEmail = new EmailServiceXYZ();
            userExample = new UserExample(serviceEmail);
            userExample.SendEmail();
            #endregion

            #region Method Injection
            serviceEmail = new EmailServiceXPTO();
            userExample = new UserExample();
            userExample.SendEmail(serviceEmail, "\nMethod Injection");

            serviceEmail = new EmailServiceXYZ();
            userExample = new UserExample();
            userExample.SendEmail(serviceEmail, "\nMethod Injection");
            #endregion

            Console.WriteLine("\nPress any key..");
            Console.ReadKey();
        }
    }
}
