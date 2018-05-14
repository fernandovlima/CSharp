using System;
namespace Aula_POO
{
	public class Aluno : Pessoa
	{

		public string Martricula
		{
			get; set;
		}
    
        //construtor
		public Aluno(){
			
		}
        
		public Aluno( string nome ) : base(nome)
		{
			Nome = nome;
		}

		public Aluno(string nome, string cpf) : base(nome, cpf)
		{
			Nome = nome;
			CPF = cpf;
		}

		public override string ShowInfoPessoa()
		{
			return "Aluno: " + Nome + "\nCPF: " + CPF + "\nMatricula: " + Martricula;

		}
	}

}

