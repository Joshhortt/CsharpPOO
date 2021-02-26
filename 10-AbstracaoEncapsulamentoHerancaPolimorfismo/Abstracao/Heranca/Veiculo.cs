using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
	abstract class Veiculo // Super classe
	{

		public string cor { get; set; }  // propriedade
		public string marca { get; set; }  // propriedade

		abstract public void Acelerar();  // Metodo Acelerar
		
	}
}
