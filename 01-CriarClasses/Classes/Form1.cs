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
			Pessoa pessoa1 = new Pessoa();  // criar nova instancia
			pessoa1.nome = "Luis";
			pessoa1.idade = 39;
			pessoa1.corCabelo = "castanho";

			Pessoa pessoa2 = new Pessoa();  // criar nova instancia
			pessoa2.nome = "Maximiliano";
			pessoa2.idade = 79;
			pessoa2.corCabelo = "branco";

			labelOutput.Text = pessoa2.nome;  
			// mostra ao clicar no botao na label a nova instancia criada pessoa2, o seu nome

		    //labelOutput.Text = pessoa2.corCabelo;

		}
	}
}
