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

		public override void Parar()  // imlementar o metodo 'override' de Parar()  -- > ao escreve lo fazer double click quando aparecer o metodo							  
		{
			//base.Parar();   // ele cria a linha de codigo abaixo que é uma instrução -- > 'base.Parar();' que no fundo a origem a super classe 'veiculo'.
			// vai correr na console novamente a mensagem que esta na origem ("Parou!"). 

			System.Diagnostics.Trace.WriteLine("Paragem do Carro!");  // Contudo a mensagem na base se comentarmos ou removermos a linha de codigo
			                                                          // e acresentarmos uma nova mensagem ira fazer o override na origem, esta irá aparecer na console.
		}
	}
}
