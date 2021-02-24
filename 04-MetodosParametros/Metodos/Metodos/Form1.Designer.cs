
namespace Metodos
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
			this.CmdExecutar = new System.Windows.Forms.Button();
			this.caixaTexto = new System.Windows.Forms.Label();
			this.caixaTexto1 = new System.Windows.Forms.Label();
			this.CmdExecutar1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CmdExecutar
			// 
			this.CmdExecutar.Location = new System.Drawing.Point(59, 166);
			this.CmdExecutar.Name = "CmdExecutar";
			this.CmdExecutar.Size = new System.Drawing.Size(75, 23);
			this.CmdExecutar.TabIndex = 0;
			this.CmdExecutar.Text = "Matematica";
			this.CmdExecutar.UseVisualStyleBackColor = true;
			this.CmdExecutar.Click += new System.EventHandler(this.CmdExecutar_Click);
			// 
			// caixaTexto
			// 
			this.caixaTexto.AutoSize = true;
			this.caixaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caixaTexto.Location = new System.Drawing.Point(36, 72);
			this.caixaTexto.Name = "caixaTexto";
			this.caixaTexto.Size = new System.Drawing.Size(127, 25);
			this.caixaTexto.TabIndex = 1;
			this.caixaTexto.Text = "Calculadora";
			// 
			// caixaTexto1
			// 
			this.caixaTexto1.AutoSize = true;
			this.caixaTexto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caixaTexto1.Location = new System.Drawing.Point(293, 72);
			this.caixaTexto1.Name = "caixaTexto1";
			this.caixaTexto1.Size = new System.Drawing.Size(62, 25);
			this.caixaTexto1.TabIndex = 2;
			this.caixaTexto1.Text = "Valor";
			// 
			// CmdExecutar1
			// 
			this.CmdExecutar1.Location = new System.Drawing.Point(289, 166);
			this.CmdExecutar1.Name = "CmdExecutar1";
			this.CmdExecutar1.Size = new System.Drawing.Size(75, 23);
			this.CmdExecutar1.TabIndex = 3;
			this.CmdExecutar1.Text = "Teste";
			this.CmdExecutar1.UseVisualStyleBackColor = true;
			this.CmdExecutar1.Click += new System.EventHandler(this.CmdExecutar1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 290);
			this.Controls.Add(this.CmdExecutar1);
			this.Controls.Add(this.caixaTexto1);
			this.Controls.Add(this.caixaTexto);
			this.Controls.Add(this.CmdExecutar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CmdExecutar;
		private System.Windows.Forms.Label caixaTexto;
		private System.Windows.Forms.Label caixaTexto1;
		private System.Windows.Forms.Button CmdExecutar1;
	}
}

