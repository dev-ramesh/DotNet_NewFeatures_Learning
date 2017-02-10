using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string To, string from, string subject, string message)
        {

            Debug.WriteLine($"Sending Mail To:  {To} From : {from} Subject: {subject} Message: {message}");

        }
    }
}
