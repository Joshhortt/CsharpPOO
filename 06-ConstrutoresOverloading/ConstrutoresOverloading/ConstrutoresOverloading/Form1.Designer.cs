﻿
namespace ConstrutoresOverloading
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
			this.LabelOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(98, 157);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 0;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// LabelOutput
			// 
			this.LabelOutput.AutoSize = true;
			this.LabelOutput.Location = new System.Drawing.Point(119, 70);
			this.LabelOutput.Name = "LabelOutput";
			this.LabelOutput.Size = new System.Drawing.Size(39, 13);
			this.LabelOutput.TabIndex = 1;
			this.LabelOutput.Text = "Output";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 334);
			this.Controls.Add(this.LabelOutput);
			this.Controls.Add(this.BtnOk);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Label LabelOutput;
	}
}

