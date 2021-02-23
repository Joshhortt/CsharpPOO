using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

	class Pessoa
	{
		// II- Parte
		public string nome; // 2. Propriedade nome
		public string apelido; //3. Propriedade apelido

		public void IdentificarSe()  // 6. Metodo
		{
			//System.Windows.Forms.MessageBox.Show(nome + " " + apelido);  8. mostra Messagebox ao clicar em OK com nome e apelido concatenado
			System.Windows.Forms.MessageBox.Show(ConstruirNome());  //12. Executa o metodo e apresenta o valor de retorno.
		}
		private string ConstruirNome()  // 9. Metodo privado com retorno de valor do tipo string
		{
			string nomeCompleto = nome + " " + apelido; // 10. definir a variavel apenas que é apenas reconhecida dentro deste bloco de codigo
			return nomeCompleto;  // 11. retorno da variavel - valor nomeCompleto --> daqui vai para o 12. que executa
		}

		// I- Parte
		/*
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
		*/
	}
}
