using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOutput_Click(object sender, EventArgs e)
		{
			Pessoa pessoa1 = new Pessoa();  // criar nova instancia pessoa2
			pessoa1.nome = "Marco";
			pessoa1.Falar();   // Quero executar o metodo Falar() que mostra uma messageBox

			Pessoa pessoa2 = new Pessoa();  // criar nova instancia pessoa 2
			pessoa2.nome = "Carlos";
			pessoa2.Falar();  // Quero executar o metodo Falar() que mostra uma messageBox

		}
	}
}
