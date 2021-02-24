using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresOverloading
{
	class Teste
	{
		string _nome;
		int _idade;

		// O Construtor
		public Teste(string nome, int idade) // Não retorna nada (nao possui void, string, int etc..). E tem o mesmo nome da classe.
		{
			_nome = nome;
			_idade = idade;
		}

		public void Apresentar() // O Metodo
		{

		}
	}
}
