﻿/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 10/21/17
 * Time: 8:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAGAILOG
{
	partial class pnlSetCand
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(143, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(273, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(143, 94);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(273, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(143, 129);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(273, 20);
			this.textBox3.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(95, 208);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(506, 176);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(60, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(60, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(60, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "MIddle Name";
			// 
			// pnlSetCand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "pnlSetCand";
			this.Size = new System.Drawing.Size(790, 486);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
