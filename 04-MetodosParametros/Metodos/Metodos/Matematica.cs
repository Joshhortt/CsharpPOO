using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
	class Matematica
	{
		// I- parte -Uma forma de fazer
		
		public int numA;  // propriedade 
		public int numB;  // propriedade
		public int Adicao()  // 1. Metodo Adicionar
		{
			int resultado = numA + numB;
			return resultado;
		}
		public int Subtracao()  // 2. Metodo Subtrair
		{
			int resultado = numA - numB;
			return resultado;
		}

		public int Multiplicacao()  // 2. Metodo Multiplicar
		{
			int resultado = numA * numB;
			return resultado;
		}
		public int Divisao()  // 2. Metodo Dividir
		{
			int resultado = numA / numB;
			return resultado;
		}
	}
}
