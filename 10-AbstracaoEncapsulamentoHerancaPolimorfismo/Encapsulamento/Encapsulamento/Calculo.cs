using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
	class Calculo
	{
		//Propriedade interna da classe definidos por defeito.
		private int percentagem1 = 5;   // Copo de Leite
		private int percentagem2 = 12;  // Martelo
		private int percentagem3 = 23;  // Perfume

		public int CalcularPrecoFinal(int precoInicial, int tipoProduto)
		{
			int precoFinal = 0;
			// calculo de preco final
			switch (tipoProduto)
			{
				case 1:  // alimento
					precoFinal = precoInicial + (precoInicial * percentagem1 / 100);
					break;

				case 2:  // ferramenta
					precoFinal = precoInicial + (precoInicial * percentagem2 / 100);
					break;

				case 3:  // cosmetico
					precoFinal = precoInicial + (precoInicial * percentagem3 / 100);
					break;
			}

			
			return precoFinal;
		}
	}
}
