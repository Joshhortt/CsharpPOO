﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			rectangulo forma1 = new rectangulo  // instancia
			{
				Largura = 50,
				Altura = 100
			};
			forma1.Apresentar();
            forma1.Desenhar();
            forma1.Desenhar_Outro();

			triangulo forma2 = new triangulo   // instancia
            {
				Largura = 150,
				Altura = 200
			};
			forma2.Apresentar();
            forma2.Desenhar();
            forma2.Desenhar_Outro();

            circunferencia forma3 = new circunferencia();   // instancia
            forma3.Largura = 250;  //podemos tambem utilizar esta forma, contudo o intellisense recomenda a forma acima simplificada
            forma3.Altura = 300;   //podemos tambem utilizar esta forma, contudo o intellisense recomenda a forma acima simplificada
            forma3.Apresentar();
            forma3.Desenhar();
            forma3.Desenhar_Outro();
        }
    }
}
