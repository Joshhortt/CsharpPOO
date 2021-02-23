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
		/*
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
		*/
		//-----------------------------------------------------------------------

		// III-parte - Uma forma ainda mais simples de fazer so com um metodo
		/*
		public int Operaçoes(int numA, int numB, string operacao)  // Metodo com 3 parametros
		{
			int resultado = -1;  // mostra -1 (se nao houver Default:) sempre que no terceiro parametro a palavara colocada nao seja 'adicao', 'subtracao', 'multiplicacao', 'divisao'

			// condicional com switch / case
			switch (operacao) 
			{
				case "adicao":
					resultado = numA + numB;
					break;
				case "subtracao":
					resultado = numA - numB;
					break;
				case "multiplicacao":
					resultado = numA * numB;
					break;
				case "divisao":
					resultado = numA / numB;
					break;
				default:
					resultado = -1000; // mostra -1000 sempre que no terceiro parametro a palavara colocada nao seja 'adicao', 'subtracao', 'multiplicacao', 'divisao'
					break;
			}
			return resultado; 
		}
		*/

		//-------------------------------------------------------------------------------------------------------------

		// IV-parte - Uma forma mais simples de fazer IF THAN ELSE

		public int Operaçoes(int numA, int numB, string operacao)  // Metodo com 3 parametros
		{
			int resultado = -1;
			if (operacao == "adicao")
				resultado = numA + numB;
			else if(operacao == "subtracao")
				resultado = numA - numB;
			else if (operacao == "multiplicacao")
				resultado = numA * numB;
			else if (operacao == "divisao")
				resultado = numA / numB;
			return resultado;
		}
	}
}
