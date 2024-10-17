// *******************  RESUMO  ******************* 
// SWITCH CASE -> Mais indicadO quando temos muitas opções para analiar
// define a lógica de maneira mais direta, sem a necessidade de comparar cada condição separadamente.


// PROJETO -> Criando um programa que avalia o dia da semana, com base no dia atual


using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            // Obtém o dia atual
            DateTime dataAtual = DateTime.Now;

            // Obtém o dia da semana com base na data atual
            DayOfWeek diaSemana = dataAtual.DayOfWeek;


            // Exemplo com SWITCH CASE
            switch (diaSemana)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Domingo");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Segunda-feira");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Terça-feira");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Quarta-feira");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Quinta-feira");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Sexta-feira");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("BLOCO DO SWITCH: Hoje é Sábado");
                    break;
            }



            // exemplo com IF ELSE 

            if (diaSemana == DayOfWeek.Monday)
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Segunda-feira");
            }
            else if (diaSemana == DayOfWeek.Tuesday)
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Terça-feira");
            }
            else if (diaSemana == DayOfWeek.Wednesday)
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Quarta-feira");
            }
            else if (diaSemana == DayOfWeek.Thursday)
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Quinta-feira");
            }
            else if (diaSemana == DayOfWeek.Friday)
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Sexta-feira");
            }
            else if (diaSemana == DayOfWeek.Saturday)
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Sábado-feira");
            }
            else
            {
                Console.WriteLine("BLOCO DO IF: Hoje é Domingo");
            }
        }
    }
}
