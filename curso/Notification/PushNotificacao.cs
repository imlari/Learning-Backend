using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.Notification
{
    public class PushNotificacao : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Enviando push: {mensagem}");
        }
    }
}