namespace NotificationAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SMS_Service smsService = new SMS_Service();

            INotificadorEmail notificador = new SMS_Adapter(smsService);

            notificador.enviarEmail("aluno@escola.com", "Aula", "Entregar atividade até as 17h.");
        }
    }
}
