using System;

namespace atividades7.classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do curso: ");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o RG do aluno: ");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("O aluno é bolsista?: ");
            string resposta = Console.ReadLine();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            if (resposta.ToLower() == "s") {
                aluno1.bolsista  = true; 
            } else if (resposta.ToLower() == "n"){
                aluno1.bolsista  = false; 
            }

            Console.WriteLine("Insira a média do aluno: ");
            aluno1.mediaFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da mensalidade: ");
            aluno1.valorDaMensalidade = double.Parse(Console.ReadLine());

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsista, aluno1.valorDaMensalidade);
        }
    }
}
