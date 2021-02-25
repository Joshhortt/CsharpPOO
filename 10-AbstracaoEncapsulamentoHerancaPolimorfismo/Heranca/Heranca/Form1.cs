using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnExecutar_Click(object sender, EventArgs e)
		{
			Veiculo veiculo = new Veiculo();  // Instancia veiculo
			
			Carro carro = new Carro(); // Instancia Carro
			
			
		}
	}
}
