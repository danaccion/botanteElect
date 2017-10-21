/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/10/17
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAGAILOG
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button button6;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlBody = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlBody
			// 
			this.pnlBody.Location = new System.Drawing.Point(214, 104);
			this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(1242, 648);
			this.pnlBody.TabIndex = 0;
			this.pnlBody.UseWaitCursor = true;
			this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBodyPaint);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(31, 426);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(143, 43);
			this.button5.TabIndex = 10;
			this.button5.Text = "View Students";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.UseWaitCursor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(31, 225);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 43);
			this.button4.TabIndex = 9;
			this.button4.Text = "Set Partylist";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.UseWaitCursor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(31, 184);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 43);
			this.button3.TabIndex = 8;
			this.button3.Text = "Set Candidate";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.UseWaitCursor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(31, 365);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(143, 43);
			this.button2.TabIndex = 7;
			this.button2.Text = "View Student";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.UseWaitCursor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(31, 324);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 43);
			this.button1.TabIndex = 6;
			this.button1.Text = "View Candidate";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.UseWaitCursor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1456, 109);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.UseWaitCursor = true;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.DarkRed;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Agency FB", 17F);
			this.richTextBox1.ForeColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(31, 154);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(143, 31);
			this.richTextBox1.TabIndex = 14;
			this.richTextBox1.Text = " SET";
			this.richTextBox1.UseWaitCursor = true;
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.Color.DarkRed;
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Font = new System.Drawing.Font("Agency FB", 17F);
			this.richTextBox2.ForeColor = System.Drawing.Color.White;
			this.richTextBox2.Location = new System.Drawing.Point(31, 294);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(143, 31);
			this.richTextBox2.TabIndex = 15;
			this.richTextBox2.Text = " VIEW";
			this.richTextBox2.UseWaitCursor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(31, 475);
			this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(143, 43);
			this.button6.TabIndex = 16;
			this.button6.Text = "Set Candidate";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.UseWaitCursor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1199, 561);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pnlBody);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.Text = "COMELEC";
			this.UseWaitCursor = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
