using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstracao
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnExecutar_Click(object sender, EventArgs e)
		{
			//Veiculo veiculo = new Veiculo(); // Instancia Veiculo
											 // veiculo.   // consegue NÃO consegue ter acesso a Acelerar, cor, marca. pq é Abstract
			//veiculo.Acelerar();  // Testar o acesso ao metodo Acelerar pela superclasse


			//Carro com implementação abstract
			Carro carro = new Carro(); // Instancia Carro 
									   //carro.   // consegue ter acesso a Acelerar, cor, marca, VelocidadeMaxima e LigarMotor.
			carro.Acelerar();  // Testar o acesso ao metodo Acelerar pela sub classe

			//Bicicleta com implementação Abstract
			Bicicleta bike = new Bicicleta();  // Instancia Bicicleta
											   // bike. // consegue ter acesso a Acelerar, cor, marca, Pedalar.	
			bike.Acelerar();  // Testar o acesso ao metodo Acelerar pela sub classe
		}
	}
}
