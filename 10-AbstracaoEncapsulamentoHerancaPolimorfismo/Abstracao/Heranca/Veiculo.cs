using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstracao
{
	abstract class Veiculo // Super classe agosta com abstract
	{

		public string cor { get; set; }  // propriedade
		public string marca { get; set; }  // propriedade

		abstract public void Acelerar();  // Metodo Acelerar abstract que obriga a que as classes derivadas o implementam.

		public void Parar()  // Metodo Parar que é automaticamente herdado.
		{
			System.Diagnostics.Trace.WriteLine("Parou!");
		}
		
	}
}
