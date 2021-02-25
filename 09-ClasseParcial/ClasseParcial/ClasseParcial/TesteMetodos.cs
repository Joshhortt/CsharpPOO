using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePartial
{
	partial class Teste
	{
		public void ApresentarNome()
		{
			System.Diagnostics.Trace.WriteLine(Nome + " " + Apelido);
		}
	}
}
