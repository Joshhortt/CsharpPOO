using System;
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
			//Matematica calculadora = new Matematica();   
			//int resultado = calculadora.Operaçoes(10,5,"abcd");  // mostra -1000, como se fosse um erro.
			//int resultado = calculadora.Operaçoes(10, 5, "adicao");
			//int resultado = calculadora.Operaçoes(10, 5, "subtracao");
			//int resultado = calculadora.Operaçoes(10, 5, "multiplicacao");
			//int resultado = calculadora.Operaçoes(10, 5, "divisao");
			//caixaTexto.Text = resultado.ToString();


			//-------------------------------------------------------------------------------------------------------------

			// IV-parte - Uma forma mais simples de fazer IF ELSE IF
			/*
			Matematica calculadora = new Matematica();   
			
			//int resultado = calculadora.Operaçoes(10, 5, "adicao");
			//int resultado = calculadora.Operaçoes(10, 5, "subtracao");
			int resultado = calculadora.Operaçoes(10, 5, "multiplicacao");
			//int resultado = calculadora.Operaçoes(10, 5, "divisao");
			caixaTexto.Text = resultado.ToString();
			*/
			//-------------------------------------------------------------------------------------------------------------

			// V-parte - 1 metodo publico e 4 metodos privados, dentro da mesma classe usando uma condicional If else if 
			/*
			Matematica calculadora = new Matematica();
			
			//int resultado = calculadora.Operaçoes(10, 5, "adicao");
			//int resultado = calculadora.Operaçoes(10, 5, "subtracao");
			int resultado = calculadora.Operacoes(10, 5, "multiplicacao");
			//int resultado = calculadora.Operaçoes(10, 5, "divisao");
			caixaTexto.Text = resultado.ToString();
			*/

			//-------------------------------------------------------------------------------------------------------------

			// VI-parte - A mesma forma da V-parte
			Matematica calculadora = new Matematica();

			//int resultado = calculadora.Operaçoes(10, 5, "adicao");
			//int resultado = calculadora.Operaçoes(10, 5, "subtracao");
			int resultado = calculadora.Operacoes(10, 5, "multiplicacao");
			//int resultado = calculadora.Operaçoes(10, 5, "divisao");
			caixaTexto.Text = resultado.ToString();
		}

		//-------------------------------------------------------------------------------------------------------------
		//-------------------------------------------------------------------------------------------------------------

		// VII-parte - Nova classe (label->Valor e botao->Teste) com passagem de valor por referencia.
		/*
		private void CmdExecutar1_Click(object sender, EventArgs e)
		{
			Teste objeto = new Teste();  // nova instancia
			int v = 10;                  // variavel
			//objeto.Aumentar(ref v);
			objeto.Diminuir(ref v);
			caixaTexto1.Text = v.ToString();
		} */

		//-------------------------------------------------------------------------------------------------------------

		// VIII-parte - Parametros com valor por defeito. (predefinidos)
		/*
		private void CmdExecutar1_Click(object sender, EventArgs e)
		{
			Teste objeto = new Teste();  // nova instancia
			int v = 10;                  // variavel

			//v = objeto.Aumentar(); // vai utilizar o valor que la esta que foi declarado como parametro que é 20 por defeito. 20+10=30
			//v = objeto.Diminuir(); // vai utilizar o valor que la esta que foi declarado como parametro que é 20 por defeito. 30-10=20
			//v = objeto.Multiplicar();  // vai utilizar o valor que la esta que foi declarado como parametro que é 5 por defeito. 5*10=50
			v = objeto.Dividir();  // vai utilizar o valor que la esta que foi declarado como parametro que é 200 por defeito. 200/10=20
			caixaTexto1.Text = v.ToString();
		}
		*/

		//-------------------------------------------------------------------------------------------------------------

		// IX-parte - Parametros com valor por defeito e um parametro sem ser por defeito

		private void CmdExecutar1_Click(object sender, EventArgs e)
		{
			Teste objeto = new Teste();  // nova instancia
			int v = 10;                  // variavel

			//v = objeto.Aumentar(300); // 10=10+300= 310
			//v = objeto.Diminuir(300); //  10=10-300= -290
			//v = objeto.Multiplicar(300);  // 10=10*300 = 3000
			v = objeto.Dividir(5);  // 100=100/5 = 20
			caixaTexto1.Text = v.ToString();
		}
	}
}
