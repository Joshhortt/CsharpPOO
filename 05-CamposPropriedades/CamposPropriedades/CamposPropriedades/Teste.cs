using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposPropriedades
{
	class Teste
	{
		// Definição de CAMPO
		string _nome; // propriedade que na verdade é um campo porque nao tem 'set' nem 'get'.
					  // Assim devemos coloca-la privada retirando o public. Nota sem public nem privado o campo é privado.
					  // Fica visivel dentro da classe mas não fora desta.
					  // E por boas praticas do programador devemos nomear os campos precedidos por underscore '_nome'.

		// Definição de PROPRIEDADE e sua verdadeira estrutura.
		public string Nome
		{
			set 
			{   // Implementação de mecanismo de validação:
				if (value == "Marco")
				{
					System.Windows.Forms.MessageBox.Show("Aconteceu um Erro!");
					_nome = "ERRO: Nome introduzido possui confidencialidade!";
				}
				else
				_nome = value;  // vai definir um valor. 'value' é uma palavra resrevada pelo C#
			}

			get 
			{
				return _nome;     //Vai buscar o valor ao campo privado
			}
		}

		public void Apresentar()
		{
			System.Windows.Forms.MessageBox.Show(_nome);
		}
	}
}
