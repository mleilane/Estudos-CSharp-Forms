using System;


// criando um sistema para aprovação ou reprovação de aluno

namespace EstruturaRepeticao
{
    class Program
    {

        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite o nome do Aluno: ");
            nome = Console.ReadLine();


            Console.WriteLine("Digite a nota1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota2 do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota3 do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            //Console.WriteLine("Olá, " + nome);
            Console.WriteLine("Sua nota final foi, " + media);



            if (media < 5)
            {
                Console.WriteLine("Infelizmente você foi REPROVADO (A) " + nome);
            }
            else if (media == 5)
            {
                Console.WriteLine("Parabéns " + nome + "! Você foi APROVADA, mas foi por pouco.");

            }
            else
            {
                Console.WriteLine("Parabéns " + nome + "! Você foi APROVADA!");
            }
        }
    }
}
