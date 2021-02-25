using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
	public partial class Form1 : Form
	{
		private int precoInicial;

		public Form1()
		{
			InitializeComponent();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void CmdExecutar_Click(object sender, EventArgs e)
		{
			// apresentar o preço final do produto
			Calculo calculadora = new Calculo(); // instancia

			// conversão de texto para valor numerico inteiro de 16 bits
			int precoInicial = Convert.ToInt16(CaixaPreco.Text);

			int tipoProduto = 0;

			if(Rb1.Checked)
					tipoProduto = 1;
			else if (Rb2.Checked)
					tipoProduto = 2;
			else if (Rb3.Checked)
						tipoProduto = 3;

			MessageBox.Show("Preço Final = " + calculadora.CalcularPrecoFinal(precoInicial, tipoProduto)); // mostra o resultado calculado
		}
	}
}
