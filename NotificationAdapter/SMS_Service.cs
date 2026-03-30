using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationAdapter
{
    public class SMS_Service
    {
        public void enviarSMS(string numero, string mensagem)
        {
            Console.WriteLine($"SMS enviado para {numero}, com mensagem: {mensagem}");
        }
    }
}
