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
		public void Aumentar(ref int valor)
		{
			valor += 5;
		}

		public void Diminuir(ref int valor)
		{
			valor -= 5;
		}
	}
}
