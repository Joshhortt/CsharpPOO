using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
	class Carro : Veiculo  // Sub-classe (a classe Carro herda da classe veiculo).
	{
		public int VelocidadeMaxima { get; set; }  // Esta propriedade so existe na classe Carro
		public void LigarMotor()  // Este metodo so existe na classe Carro
		{

		}

		public override void Acelerar() // Implementação do override, devido a atribuição de 'abstract' a superclass 'Veiculo'
		{
			// throw new NotImplementedException(); Ao criar esta implmentação podemos comentá-la ou remover daqui
			System.Diagnostics.Trace.WriteLine("O Carro Acelerou..!");
		}
	}
}
