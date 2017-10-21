/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 10/21/17
 * Time: 7:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAGAILOG
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(60, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 31);
			this.button1.TabIndex = 0;
			this.button1.Text = "LOGIN";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(33, 163);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(188, 26);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(33, 109);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(188, 26);
			this.richTextBox2.TabIndex = 3;
			this.richTextBox2.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(33, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password:";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 459);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);

		}
	}
}
