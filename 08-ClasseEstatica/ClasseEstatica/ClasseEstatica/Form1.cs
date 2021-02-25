using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseEstatica
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			Normal objeto = new Normal();  // Instancia
			objeto.Nome = "Jose Horta"; // Atribuido o valor da propriedade Nome
			objeto.ApresentarNome();  // objeto que vai chamar o metodo da classe

			Normal objetoNovo = new Normal();  // criar nova instancia de objetoNovo apartir da classe estatica
			objetoNovo.Nome = "Marco Poluzzo";
			objetoNovo.ApresentarNome();

			// Estatica objetoInstancia = new Estatica(); --> Nao é possivel criar instancia da classe Estatica
			// Basta fazer isto:
			Estatica.Nome = "Susana Belchior";
			Estatica.ApresentarNome();
		}
	}
}
