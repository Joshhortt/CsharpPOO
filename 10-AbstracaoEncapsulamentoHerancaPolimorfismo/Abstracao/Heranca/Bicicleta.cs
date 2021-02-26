using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
	class Bicicleta : Veiculo  // Sub-classe (a classe Bicicleta herda da classe veiculo).
	{
		public void Pedalar()  // Este metodo so existe na classe Bicicleta
		{

		}
		public override void Acelerar()  // Implementação do override, devido a atribuição de 'abstract' a superclass 'Veiculo'
		{
			// throw new NotImplementedException(); Ao criar esta implmentação podemos comentá-la ou remover daqui 
			System.Diagnostics.Trace.WriteLine("A Bicicleta Acelerou..!");
		}

	}
}
