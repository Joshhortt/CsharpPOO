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
			Carro carro = new Carro(); // Instancia Carro 
			// carro.   // consegue ter acesso a Acelerar, cor, marca, VelocidadeMaxima.

			Bicicleta bike = new Bicicleta();  // Instancia Bicicleta
			// bike. // consegue ter acesso a Acelerar, cor, marca, Pedalar.	
		}
	}
}
