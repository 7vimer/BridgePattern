﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SendingEmail.UsersClasses
{
    public class InfoGMail : InfoEmail
    {
        public InfoGMail (StringPair emailAdressTo, string subject, string body) 
        : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("pominov.dania@gmail.com", "Поминов Даниил Викторович");
            EmailPassword = "gtyqwvethksytkef";
            Port = 587;
        }

    }
}
