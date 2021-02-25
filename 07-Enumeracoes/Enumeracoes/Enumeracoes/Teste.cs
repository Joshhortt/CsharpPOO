using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
	class Teste
	{

		// Criar uma Enumeração (2 formas - code snippet ou manual)
		public enum DiasDaSemana
		{
			domingo, segunda, terça, quarta, quinta, sexta, sabado
		}


		public void ApresentarDia(DiasDaSemana dia)
		{
			System.Diagnostics.Trace.WriteLine("O dia escolhido foi " + dia);
		}
	}
}
