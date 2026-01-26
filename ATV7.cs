using System;
using System.Threading;

namespace ATV7
{
    public static class Conversor
    {
        public static double CelsisusParaFarenheit(double c) => (c * 9 / 5 +32);  
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====App multi-tarefa");

            Thread tarefaFundo = new Thread(ProcessamentoPesado);
            tarefaFundo.Start();

            while(tarefaFundo.IsAlive)
            {
                Console.WriteLine("Digite uma temperatura em °C para converter(ou 'sair'");
                string input = Console.ReadLine();

                if(input == "sair") break;

                if(double.TryParse(input, out double celsius))
                {
                    double farenheit = Conversor.CelsisusParaFarenheit(celsius);
                    Console.WriteLine($">>>{celsius}°C = {farenheit}°F");
                }
                else
                {
                    Console.WriteLine("valor invalido");
                }
            }
            Console.WriteLine("Programa finalizado");
        }

        static void ProcessamentoPesado()
        {
            Console.WriteLine("[SYSTEM] iniciando backup em segundo plano...");
            for(int i = 0; i <=100; i += 20)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"\n[SYSTEM] progresso do backup{i}% completo");
                Console.WriteLine("Digite a temperatura");
            }
            Console.WriteLine("\n[SYSTEM} backup finalizado com sucesso");
        } 
    }
}