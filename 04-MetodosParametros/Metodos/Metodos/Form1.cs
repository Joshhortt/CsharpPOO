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
			/*
			Matematica calculadora = new Matematica();  
			calculadora.numA = 60; // variavel int utilizada nos calculos
			calculadora.numB = 30; // variavel int utilizada nos calculos

			// label chamada de caixaTexto = ao calculo do metodo Adicao() ou Subtracao(), etc.. que converte para String
			//caixaTexto.Text = calculadora.Adicao().ToString();
			//caixaTexto.Text = calculadora.Subtracao().ToString();
			caixaTexto.Text = calculadora.Multiplicacao().ToString();
			//caixaTexto.Text = calculadora.Divisao().ToString();
			*/

			//-------------------------------------------------------------------------------------------------------------

			// II-parte - Uma forma mais simples de fazer
			//Matematica calculadora = new Matematica();   
			//int resultado = calculadora.Adicao(60, 30);
			//int resultado = calculadora.Subtracao(60, 30);
			//int resultado = calculadora.Multiplicacao(60, 30);
			//int resultado = calculadora.Divisao(60, 30);
			//caixaTexto.Text = resultado.ToString();
			// label chamada de caixaTexto = ao calculo do metodo Adicao() ou Subtracao(), etc.. que converte para String, 
			// contudo aqui o metodo Adicao precisa de dois valores int entre parentesis.

			//-------------------------------------------------------------------------------------------------------------

			// III-parte - Uma forma ainda mais simples de fazer so com um metodo
			Matematica calculadora = new Matematica();   
			//int resultado = calculadora.Operaçoes(10,5,"abcd");  // mostra -1000, como se fosse um erro.
			int resultado = calculadora.Operaçoes(10, 5, "adicao");
			//int resultado = calculadora.Operaçoes(10, 5, "subtracao");
			//int resultado = calculadora.Operaçoes(10, 5, "multiplicacao");
			//int resultado = calculadora.Operaçoes(10, 5, "divisao");
			caixaTexto.Text = resultado.ToString();
		}
	}
}
