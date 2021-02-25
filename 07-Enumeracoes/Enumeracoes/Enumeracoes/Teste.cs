using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
	class Teste
	{

		// Criar uma Enumeração (2 formas - code snippet ou manual) - 4 linhas de codigo
		public enum DiasDaSemana
		{
			domingo, segunda, terça, quarta, quinta, sexta, sabado
		}

		// Criar outra Enumeração - 1 linha de codigo.
		public enum Movimentos { cima, baixo, esquerda, direita }


		// Metodo
		public void ApresentarDia(DiasDaSemana dia)
		{
			System.Diagnostics.Trace.WriteLine("O dia escolhido foi " + dia);
		}

		//Metodo
		public void Mover(Movimentos direcao)
		{
			System.Diagnostics.Trace.WriteLine("O jogador moveu-se para " + direcao);
		}
	}
}
