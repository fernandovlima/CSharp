using System;

namespace Aula_POO
{
    class Program
    {
        static void Main(string[] args)
        {
			Aluno aluno = new Aluno();

			aluno.Nome = "Fernando"; //set
			aluno.CPF = "123456789090";
			Console.WriteLine("Aluno: " + aluno.Nome + "\nCPF: " + aluno.CPF);
			//Console.WriteLine(aluno.ShowInfoPessoa);
		
		}
    }
}
