using System;
namespace Aula_POO
{
	abstract class Pessoa
    {
        public Pessoa()
        {
        }

		public Pessoa(string nome){
			Nome = nome;	
		}

		public Pessoa(string nome, string cpf){
			Nome = nome;
			CPF = cpf;
		}
		//atributos
		private string nome;


        //propriedade
        public string Nome
        {
            get => nome;
            set => nome = value;
        }


        public string CPF { get; set; }


		public abstract string ShowInfoPessoa();



    }
}
