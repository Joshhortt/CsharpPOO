﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstrutoresOverloading
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			Teste v = new Teste("Marco Poluzzo", 40);
			v.Apresentar();
			v.Apresentar(" >>> ");
			v.Apresentar();
		}
	}
}
