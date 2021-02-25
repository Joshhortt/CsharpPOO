
namespace Enumeracoes
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnCima = new System.Windows.Forms.Button();
			this.BtnEsquerda = new System.Windows.Forms.Button();
			this.BtnDireita = new System.Windows.Forms.Button();
			this.BtnBaixo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnOk
			// 
			this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnOk.Location = new System.Drawing.Point(199, 376);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(291, 43);
			this.BtnOk.TabIndex = 0;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(195, 329);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Clique em Ok para mostrar Output";
			// 
			// BtnCima
			// 
			this.BtnCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCima.Location = new System.Drawing.Point(292, 73);
			this.BtnCima.Name = "BtnCima";
			this.BtnCima.Size = new System.Drawing.Size(138, 43);
			this.BtnCima.TabIndex = 2;
			this.BtnCima.Text = "Cima";
			this.BtnCima.UseVisualStyleBackColor = true;
			this.BtnCima.Click += new System.EventHandler(this.BtnCima_Click);
			// 
			// BtnEsquerda
			// 
			this.BtnEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEsquerda.Location = new System.Drawing.Point(144, 122);
			this.BtnEsquerda.Name = "BtnEsquerda";
			this.BtnEsquerda.Size = new System.Drawing.Size(146, 43);
			this.BtnEsquerda.TabIndex = 3;
			this.BtnEsquerda.Text = "Esquerda";
			this.BtnEsquerda.UseVisualStyleBackColor = true;
			this.BtnEsquerda.Click += new System.EventHandler(this.BtnEsquerda_Click);
			// 
			// BtnDireita
			// 
			this.BtnDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDireita.Location = new System.Drawing.Point(433, 122);
			this.BtnDireita.Name = "BtnDireita";
			this.BtnDireita.Size = new System.Drawing.Size(138, 43);
			this.BtnDireita.TabIndex = 4;
			this.BtnDireita.Text = "Direita";
			this.BtnDireita.UseVisualStyleBackColor = true;
			this.BtnDireita.Click += new System.EventHandler(this.BtnDireita_Click);
			// 
			// BtnBaixo
			// 
			this.BtnBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBaixo.Location = new System.Drawing.Point(292, 171);
			this.BtnBaixo.Name = "BtnBaixo";
			this.BtnBaixo.Size = new System.Drawing.Size(138, 43);
			this.BtnBaixo.TabIndex = 5;
			this.BtnBaixo.Text = "Baixo";
			this.BtnBaixo.UseVisualStyleBackColor = true;
			this.BtnBaixo.Click += new System.EventHandler(this.BtnBaixo_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(410, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Clique na direcao desejada para mostrar Output";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 500);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnBaixo);
			this.Controls.Add(this.BtnDireita);
			this.Controls.Add(this.BtnEsquerda);
			this.Controls.Add(this.BtnCima);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnOk);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnCima;
		private System.Windows.Forms.Button BtnEsquerda;
		private System.Windows.Forms.Button BtnDireita;
		private System.Windows.Forms.Button BtnBaixo;
		private System.Windows.Forms.Label label2;
	}
}

