using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamposPropriedades
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			Teste v = new Teste();
			//------------------ Primeira forma de fazer ---------------
			//v._nome = "Jose Horta"; // ficou inacessivel pq o campo foi definido como privado, antes de ter criado a estrutura de propriedade
			//v.Nome = "Jose Hottiger";

			//------------------- Nova forma de fazer ------------------
			v.Nome = textBox.Text;
			v.Apresentar();
		}
	}
}
