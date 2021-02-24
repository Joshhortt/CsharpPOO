using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
	class Teste
	{

		// VII-parte - Nova Classe (label->Valor e botao->Teste) com passagem de valor por referencia.
		/*
		public void Aumentar(ref int valor)  // parametro com passagem de valor por referencia
		{
			valor += 5;  // aumenta valor da variavel em 5 (10+5) = 15
		}

		public void Diminuir(ref int valor)  // parametro com passagem de valor por referencia
		{
			valor -= 5;  // diminui valor da variavel em 5 (10-5) = 5
		} */


		//-------------------------------------------------------------------------------------------------------------

		// VIII-parte - Parametros com valor por defeito.(predefinidos)

		public int Aumentar(int valor = 20)
		{
			valor += 10;
			return valor;
		}

		public int Diminuir(int valor = 30)
		{
			valor -= 10;
			return valor;
		}

		public int Multiplicar(int valor = 5)
		{
			valor *= 10;
			return valor;
		}

		public int Dividir (int valor = 200)
		{
			valor /= 10;
			return valor;
		}
	}
}
