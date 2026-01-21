using System;
using System.Collections.Generic;

namespace Atv4 
{
    public interface INotificavel
    {
        void EnviarMsg(string msg);
    }

    public class Email : INotificavel
    {
        public string EmailDestino { get; set; }

        public void EnviarMsg(string msg)
        {
            Console.WriteLine($"[Email] Para: {EmailDestino} | Conteudo: '{msg}'");
        }
    }

    public class SMS : INotificavel
    {
        public string NumTelefone { get; set; }

        public void EnviarMsg(string msg)
        {
            Console.WriteLine($"[SMS] Enviando para {NumTelefone}: '{msg}'");
        }
    }

    public class PushNotification : INotificavel
    {
        public void EnviarMsg(string msg)
        {
            Console.WriteLine($"[PUSH] Notificacao no APP; '{msg}'");
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public List<INotificavel> CanaisDeContato { get; set; } = new List<INotificavel>();

        public void NotificarGeral(string aviso)
        {
            Console.WriteLine($"-------Notificando {Nome}----");
            foreach (var canal in CanaisDeContato)
            {
                canal.EnviarMsg(aviso);
            }
            Console.WriteLine("--------------------------\n");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Usuario user1 = new Usuario { Nome = "Kaick Gomes" };
            user1.CanaisDeContato.Add(new Email { EmailDestino = "gkaick600@gmail.com" });
            user1.CanaisDeContato.Add(new SMS { NumTelefone = "83-98400-2891" });

            Usuario user2 = new Usuario { Nome = "Cefras" };
            user2.CanaisDeContato.Add(new PushNotification());

            user1.NotificarGeral("Seu pedido saiu para entrega");
            user2.NotificarGeral("Começou o happy hour!");
            Console.ReadKey();
        }
    }
}
