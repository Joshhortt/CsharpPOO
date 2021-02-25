
namespace Encapsulamento
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
			this.Rb1 = new System.Windows.Forms.RadioButton();
			this.Rb2 = new System.Windows.Forms.RadioButton();
			this.Rb3 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.CaixaPreco = new System.Windows.Forms.TextBox();
			this.CmdExecutar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Rb1
			// 
			this.Rb1.AutoSize = true;
			this.Rb1.Checked = true;
			this.Rb1.Location = new System.Drawing.Point(76, 84);
			this.Rb1.Name = "Rb1";
			this.Rb1.Size = new System.Drawing.Size(76, 17);
			this.Rb1.TabIndex = 0;
			this.Rb1.TabStop = true;
			this.Rb1.Text = "Copo Leite";
			this.Rb1.UseVisualStyleBackColor = true;
			// 
			// Rb2
			// 
			this.Rb2.AutoSize = true;
			this.Rb2.Location = new System.Drawing.Point(76, 107);
			this.Rb2.Name = "Rb2";
			this.Rb2.Size = new System.Drawing.Size(60, 17);
			this.Rb2.TabIndex = 1;
			this.Rb2.Text = "Martelo";
			this.Rb2.UseVisualStyleBackColor = true;
			this.Rb2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// Rb3
			// 
			this.Rb3.AutoSize = true;
			this.Rb3.Location = new System.Drawing.Point(76, 130);
			this.Rb3.Name = "Rb3";
			this.Rb3.Size = new System.Drawing.Size(64, 17);
			this.Rb3.TabIndex = 2;
			this.Rb3.Text = "Perfume";
			this.Rb3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Bens de Necessidade";
			// 
			// CaixaPreco
			// 
			this.CaixaPreco.Location = new System.Drawing.Point(76, 177);
			this.CaixaPreco.Name = "CaixaPreco";
			this.CaixaPreco.Size = new System.Drawing.Size(76, 20);
			this.CaixaPreco.TabIndex = 4;
			// 
			// CmdExecutar
			// 
			this.CmdExecutar.Location = new System.Drawing.Point(160, 175);
			this.CmdExecutar.Name = "CmdExecutar";
			this.CmdExecutar.Size = new System.Drawing.Size(75, 23);
			this.CmdExecutar.TabIndex = 5;
			this.CmdExecutar.Text = "Executar";
			this.CmdExecutar.UseVisualStyleBackColor = true;
			this.CmdExecutar.Click += new System.EventHandler(this.CmdExecutar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 299);
			this.Controls.Add(this.CmdExecutar);
			this.Controls.Add(this.CaixaPreco);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Rb3);
			this.Controls.Add(this.Rb2);
			this.Controls.Add(this.Rb1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton Rb1;
		private System.Windows.Forms.RadioButton Rb2;
		private System.Windows.Forms.RadioButton Rb3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CaixaPreco;
		private System.Windows.Forms.Button CmdExecutar;
	}
}

