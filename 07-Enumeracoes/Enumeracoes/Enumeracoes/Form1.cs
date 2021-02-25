using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracoes
{
	public partial class Form1 : Form
	{

		Teste jogador;  // objeto jogador
		public Form1()  // Construtor
		{
			InitializeComponent();

			jogador = new Teste();
		}
		//---------------------------------------------------------------------
		// objeto com um botao
		private void BtnOk_Click(object sender, EventArgs e)
		{
			Teste objecto = new Teste();  
			objecto.ApresentarDia(Teste.DiasDaSemana.sabado);
			objecto.Mover(Teste.Movimentos.direita);
		}
		//----------------------------------------------------------------------

		// Outra forma de fazer com objeto criado 'jogador' com 4 botoes
		private void BtnCima_Click(object sender, EventArgs e)
		{
			// Move para cima
			jogador.Mover(Teste.Movimentos.cima);
		}

		private void BtnDireita_Click(object sender, EventArgs e)
		{
			// Move para direita
			jogador.Mover(Teste.Movimentos.direita);
		}

		private void BtnBaixo_Click(object sender, EventArgs e)
		{
			// Move para baixo
			jogador.Mover(Teste.Movimentos.baixo);
		}

		private void BtnEsquerda_Click(object sender, EventArgs e)
		{
			// Move para esquerda
			jogador.Mover(Teste.Movimentos.esquerda);
		}
	}
}
