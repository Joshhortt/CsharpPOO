﻿using System;
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
			// II- Parte
			Pessoa novaPessoa = new Pessoa();  // 1. criar nova instancia
			novaPessoa.nome = "Max";  // 4. variavel de nome Mac
			novaPessoa.apelido = "Murdoch"; // 5.variavel de apelido Murdoch

			// identificar-se
			novaPessoa.IdentificarSe();  // 7.Estou a chamar a execução do metodo IdentificarSe()

			// I.Parte
			/*
			Pessoa novaPessoa = new Pessoa();  // 3. criar nova instancia
			novaPessoa.Falar();  // 4. Estou a chamar a execução do metodo Falar()
			novaPessoa.Correr();  // 7.Estou a chamar a execução do metodo Correr()
			// novaPessoa.Saltar();  // 10. Estou a chamar a execução do metodo Correr() (sem acesso - private)
			*/
		}
	}
}
