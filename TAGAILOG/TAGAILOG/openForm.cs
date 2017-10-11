/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 10/07/17
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAGAILOG
{
	/// <summary>
	/// Description of openForm.
	/// </summary>
	public partial class openForm : Form
	{
		
		pnlKeyControl key = new pnlKeyControl();
		pnltimeStart time = new pnltimeStart();
		public openForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			key.Name = "key";
			key.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(key);
		    
		    time.Name = "time";
			time.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(time);
		    ShowControl("key");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void HandleControl(string cntrlName)
        {
            pnlBody.Controls[cntrlName].BringToFront();
        }
		
		void ShowControl(string controlName)
		{
			pnlBody.Controls[controlName].BringToFront();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ShowControl("time");
		}
		void OpenFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
