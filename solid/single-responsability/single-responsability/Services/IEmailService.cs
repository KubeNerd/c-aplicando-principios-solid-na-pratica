using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace single_responsability.Services
{
    interface IEmailService
    {
        public void EnviarEmail(string EmailFrom, string EmailTo, string EmailSubject, string EmailBody);
    }
}
