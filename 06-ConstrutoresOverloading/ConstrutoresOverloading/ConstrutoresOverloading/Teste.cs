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
		//==========================================================================================================================
		public void Apresentar() // O Metodo
		{
			System.Windows.Forms.MessageBox.Show(_nome + " -> " + _idade + " anos.");
		}
		//============================= Overload mas com assinatura diferente string ======================================================
		public void Apresentar(string separador) // O Metodo com o mesmo nome, mas para que seja aceite tem de haver um ou mais parametros nele.
		{
			System.Windows.Forms.MessageBox.Show(_nome + separador + _idade + " anos.");
		}

		//============================= Overload mas com assinatura diferente string e int ======================================================
		public void Apresentar(string separador, int idade) // O Metodo com o mesmo nome, mas para que seja aceite tem de haver um ou mais parametros nele.
		{
			System.Windows.Forms.MessageBox.Show(_nome + separador + idade + " anos.");
		}

	}
}
