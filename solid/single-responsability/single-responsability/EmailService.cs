using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using single_responsability.Services;

namespace single_responsability
{
    class EmailService: IEmailService
    {
        public string EMailFrom { get; set; }

        public string EMailTo { get; set; } = string.Empty;

        public string EMailSubject { get; set; }

        public string EMailBody { get; set; }


        public void EnviarEmail()
        {
          
        }
        public void EnviarEmail(string EmailFrom, string EmailTo, string EmailSubject, string EmailBody) 
        {
            if (string.IsNullOrEmpty(EmailFrom) && string.IsNullOrEmpty(EmailTo) && string.IsNullOrEmpty(EmailSubject) && string.IsNullOrEmpty(EmailBody)) 
            {
                throw new Exception("Does not be null parameters.");
            }
            this.EMailFrom = EmailFrom;
            this.EMailTo = EmailTo;
            this.EMailSubject = EmailSubject;
            this.EMailBody = EmailBody;


            Console.WriteLine($"Send: FROM {this.EMailFrom}\n TO {this.EMailTo}\n SUBJECT {this.EMailSubject}\n BODY {this.EMailBody}\n");

        }
            
    }
}
