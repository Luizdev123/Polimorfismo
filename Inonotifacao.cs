using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    
    internal interface INotificacao
    {
        void Enviar();
    }

    
    internal class NotificacaoEmail : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por email...");
        }

        
        public void Enviar(string anexo)
        {
            Console.WriteLine($"Enviando email com anexo: {anexo}");
        }
    }

    
    internal class NotificacaoSms : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por SMS...");
        }
    }

    
    internal class NotificacaoPush : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação push para o app...");
        }
    }
}
