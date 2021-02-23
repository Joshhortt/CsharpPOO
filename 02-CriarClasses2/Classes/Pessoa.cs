using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Pessoa
	{  // Propriedades da classe 'Classes'
		public string nome;
		public int idade;
		// private string corCabelo;   propriedade privada (está escondida)

		public void Falar()  // Este metodo (letra maiuscula), nao vai devolver nada (vazio)
		{
			System.Windows.Forms.MessageBox.Show("Olá o meu nome é " + nome);
		}

		public void ApresentarSe()
		{
			System.Windows.Forms.MessageBox.Show("Olá o meu nome é " + nome + " e tenho " + idade + " anos de idade.");

		}
	}
}
