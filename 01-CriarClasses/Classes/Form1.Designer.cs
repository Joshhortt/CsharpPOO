
namespace Classes
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
			this.BtnOutput = new System.Windows.Forms.Button();
			this.labelOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnOutput
			// 
			this.BtnOutput.Location = new System.Drawing.Point(101, 227);
			this.BtnOutput.Name = "BtnOutput";
			this.BtnOutput.Size = new System.Drawing.Size(75, 23);
			this.BtnOutput.TabIndex = 0;
			this.BtnOutput.Text = "OK";
			this.BtnOutput.UseVisualStyleBackColor = true;
			this.BtnOutput.Click += new System.EventHandler(this.BtnOutput_Click);
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOutput.Location = new System.Drawing.Point(100, 124);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(76, 25);
			this.labelOutput.TabIndex = 1;
			this.labelOutput.Text = "Output";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 358);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.BtnOutput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnOutput;
		private System.Windows.Forms.Label labelOutput;
	}
}

