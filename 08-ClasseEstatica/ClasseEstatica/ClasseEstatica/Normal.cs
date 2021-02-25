using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
	class Normal
	{

		public string Nome { set; get; }  // A propriedade

		public void ApresentarNome()  // O metodo
		{
			System.Diagnostics.Trace.WriteLine(Nome);
		}
	}
}
