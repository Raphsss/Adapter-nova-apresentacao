using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationAdapter
{
    public class SMS_Adapter : INotificadorEmail
    {
        private readonly SMS_Service _smsService;
        public SMS_Adapter(SMS_Service sms)
        {
            _smsService = sms;
        }
        public void enviarEmail(string email, string assunto, string mensagem)
        {
            string numero = "7999874643"; // Simula consulta no banco de dados para obter o numero

            string texto = $"{assunto} - {mensagem}";

            _smsService.enviarSMS(numero, texto);
            Console.WriteLine($"Email enviado com sucesso!");
        }
    }
}
