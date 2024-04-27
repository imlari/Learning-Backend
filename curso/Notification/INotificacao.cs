using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.Notification
{
    public interface INotificacao
    {
        void Enviar(string mensagem);
    }
}