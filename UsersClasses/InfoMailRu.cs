using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SendingEmail.UsersClasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body)
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("lfyz121@mail.ru", "Поминов Даниил Викторович");
            EmailPassword = "g34HGAmRKTGe76bm8r13";
            Port = -1;
        }
        
    }
}
