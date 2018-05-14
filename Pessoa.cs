using System;
namespace Aula_POO
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

		public Pessoa(string nome){
			
		}

		public Pessoa(string nome, string cpf){
			
		}
		//atributos
		protected string nome;

        //propriedade
        public string Nome
        {
            get => nome;
            set => nome = value;
        }


        public string CPF { get; set; }


    }
}
