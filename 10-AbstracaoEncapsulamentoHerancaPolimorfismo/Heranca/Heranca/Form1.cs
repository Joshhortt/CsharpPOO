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
			// Instancia Veiculo
			Veiculo veiculo = new Veiculo(); 
			// veiculo.   // consegue ter acesso a Acelerar, cor, marca.
			veiculo.Acelerar();  // Testar o acesso ao metodo Acelerar pela superclasse

			// Instancia Carro 
			Carro carro = new Carro(); 
			//carro.   // consegue ter acesso a Acelerar, cor, marca, VelocidadeMaxima e LigarMotor.
			carro.Acelerar();  // Testar o acesso ao metodo Acelerar pela sub classe

			// Instancia Bicicleta
			Bicicleta bike = new Bicicleta();  
			// bike. // consegue ter acesso a Acelerar, cor, marca, Pedalar.	
			bike.Acelerar();  // Testar o acesso ao metodo Acelerar pela sub classe
		}
	}
}
