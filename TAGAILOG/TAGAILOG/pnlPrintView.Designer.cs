/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/18/17
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAGAILOG
{
	partial class pnlPrintView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataitems;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataitems = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataitems)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(1070, 611);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "PRINT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dataitems
			// 
			this.dataitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataitems.Location = new System.Drawing.Point(0, 0);
			this.dataitems.Name = "dataitems";
			this.dataitems.Size = new System.Drawing.Size(1053, 667);
			this.dataitems.TabIndex = 3;
			this.dataitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataitemsCellContentClick);
			// 
			// pnlPrintView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataitems);
			this.Controls.Add(this.button1);
			this.Name = "pnlPrintView";
			this.Size = new System.Drawing.Size(1162, 650);
			((System.ComponentModel.ISupportInitialize)(this.dataitems)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
