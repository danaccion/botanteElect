/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/10/17
 * Time: 9:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAGAILOG
{
	partial class pnlViewCandidate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
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
			this.dataitems = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataitems)).BeginInit();
			this.SuspendLayout();
			// 
			// dataitems
			// 
			this.dataitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataitems.Location = new System.Drawing.Point(0, 0);
			this.dataitems.Name = "dataitems";
			this.dataitems.Size = new System.Drawing.Size(932, 667);
			this.dataitems.TabIndex = 0;
			this.dataitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
			// 
			// pnlViewCandidate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.dataitems);
			this.Name = "pnlViewCandidate";
			this.Size = new System.Drawing.Size(932, 667);
			((System.ComponentModel.ISupportInitialize)(this.dataitems)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
