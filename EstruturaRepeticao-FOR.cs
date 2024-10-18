// EXERCICIO 01 -> Criar um algoritmo para exibir os números de 1 a 10 em ordem crescente 
// EXERCICIO 02 -> Criar um algoritmo para exibir a tabuada do 7
// EXERCICIO 03 -> Criar um algoritmo onde o usuario vai informar um nº inteiro e o sistema vai imprimir a tabuada desse nª


using System;


namespace Aula
{
    class For
    {

        static void Main(string[] args)
        {
            // exemplo 01

            for (int contador = 10; contador >= 1; contador --) //contador menos ele mesmo
            {
                Console.WriteLine("-> " + contador);
            }

            // exemplo 02
            for (int contador = 1; contador <= 10; contador++) //contador mais ele mesmo
            {
                Console.WriteLine("7 x {0} = {1} ", contador, 7 * contador);
                // aqui estamos usando interpolação de strings, o {0} vai receber o valor da variável contador, que é o primeiro valor após a vírgula
                // e o {1} vai receber o resultado de 7 * contador, que é o segundo valor
            }

            // exemplo 03
            Console.WriteLine("Informe um número para obter a tabuada: ");

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nA tabuada do número {numero} é:\n");

            for (int contador = 1; contador <= 10; contador++) //contador mais ele mesmo
            {
                Console.WriteLine("{2} x {0} = {1} ", contador, numero * contador, numero);
                // {0} vai receber o valor da variável contador, que é o primeiro valor após a vírgula
                // {1} vai receber o resultado de numero * contador, que é o segundo valor
                // {2} Será substituído pelo valor da variável numero, que é o terceiro valor após a vírgula
            }


        }

    }
}