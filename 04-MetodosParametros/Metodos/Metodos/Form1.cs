﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CmdExecutar_Click(object sender, EventArgs e)
		{

			// I-parte - Uma forma de fazer
			
			Matematica calculadora = new Matematica();   // Criar nova instancia
			calculadora.numA = 60; // variavel int utilizada nos calculos
			calculadora.numB = 30; // variavel int utilizada nos calculos

			// label chamada de caixaTexto = ao calculo do metodo Adicao() ou Subtracao(), etc.. que converte para String
			//caixaTexto.Text = calculadora.Adicao().ToString();
			//caixaTexto.Text = calculadora.Subtracao().ToString();
			caixaTexto.Text = calculadora.Multiplicacao().ToString();
			//caixaTexto.Text = calculadora.Divisao().ToString();
			
		}
	}
}