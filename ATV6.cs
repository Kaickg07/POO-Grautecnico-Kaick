using System;
using System.IO;

namespace ATV6
{
    public static class Logger
    {
        private static string arquivolog = "sistema_log.txt";

        public static void RegistrarAcao(string acao)
        {
            using(StreamWriter sw = File.AppendText(arquivolog))
            {
                sw.WriteLine($"{DateTime.Now}) - {acao}");
            }
            Console.WriteLine("Log salvo no Disco.");
        }


        public static void LerLogs()
        {
            Console.WriteLine("\n---- Lendo historicos de Logs -----");
            if (File.Exists(arquivolog))
            {
                using (StreamReader sr = File.OpenText(arquivolog))
                {
                    string linha;
                    while((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhuma log encontrada");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger.RegistrarAcao("Sistema inicializado");
            Logger.RegistrarAcao("Usuario 'admin' logou");
            Logger.RegistrarAcao("Erro de conexao simulado");

            Logger.LerLogs();

            Console.WriteLine("\nVerfique a pasta do executavel para encontrar 'sistema_log.txt.'");
            Console.ReadKey();
        }
    }
}