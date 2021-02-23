using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Pessoa
	{  
		public void Falar()  //1. metodo sem qualuqer retorno de valor. 
		{
			System.Windows.Forms.MessageBox.Show("Falar.");   //2. MessageBox com a mensagem
		}
		public void Correr() //5. metodo sem qualuqer retorno de valor. 
		{
			System.Windows.Forms.MessageBox.Show("Correr.");   //6. MessageBox com a mensagem
			Saltar();    //11. O metodo privado  Saltar() faz parte desta classe Pessoa, 
			             //por isso é possivel chamá-lo daqui e desta forma mesmo sendo privado
		}

		private void Saltar()  //8. metodo sem qualuqer retorno de valor.
		{
			System.Windows.Forms.MessageBox.Show("Saltar.");  //9. MessageBox com a mensagem
		}

	}
}
