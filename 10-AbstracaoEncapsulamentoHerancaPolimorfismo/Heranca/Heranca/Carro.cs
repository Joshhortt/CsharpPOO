using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
	class Carro : Veiculo  // Sub-classe (a classe Carro herda da classe veiculo).
	{
		public int VelocidadeMaxima { get; set; }  // Este metodo so existe na classe Carro
		public int LigarMotor { get; set; }  // Este metodo so existe na classe Carro
	}
}
