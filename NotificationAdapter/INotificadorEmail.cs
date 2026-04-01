using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationAdapter
{
    public interface INotificadorEmail
    {
        void enviarEmail(string destinatario, string asunto, string messagem);
    }
}
