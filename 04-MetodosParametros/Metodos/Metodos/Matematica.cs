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
		/*                              
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

		public int Multiplicacao()  // 3. Metodo Multiplicar
		{
			int resultado = numA * numB;
			return resultado;
		}
		public int Divisao()  // 4. Metodo Dividir
		{
			int resultado = numA / numB;
			return resultado;
		}                             
		*/

		//-----------------------------------------------------------------------

		// II-parte - Uma forma mais simples de fazer
		public int Adicao(int numA, int numB)  // 1. Metodo Adicionar com dois parametros int
		{
			return numA + numB;
		}

		public int Subtracao(int numA, int numB)  // 2. Metodo Subtrair
		{
			return numA - numB;
		}

		public int Multiplicacao(int numA, int numB)  // 3. Metodo Multiplicar
		{
			return numA * numB;
		}
		public int Divisao(int numA, int numB)  // 4. Metodo Dividir
		{
			return numA / numB;
		}
	}
}
