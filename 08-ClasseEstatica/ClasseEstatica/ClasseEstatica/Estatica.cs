using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
	public static class Estatica // Criar classe static. A diferença da classe normal que nao é static é que esta tem de ser instanciada.
		                         // A classe static permite-nos logo criar metodos e propriedades que ficam automaticamente acessiveis
								 // a toda a estrutura do codigo de programação que estou a construir,
	{
		// public string Nome;  Nao vai funcionar pq tem de ser declara tambem static

		public static string Nome;  // campo static

		public static string NomePrograma = "Aplicação de Teste";  // Propriedade static que ja esta definida e com valor atribuido

		public static void ApresentarNome()  // Metodo static
		{
			System.Diagnostics.Trace.WriteLine(Nome);
		}
	}
}
