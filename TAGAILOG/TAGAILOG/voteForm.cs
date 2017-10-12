/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 10/07/17
 * Time: 9:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAGAILOG
{
	/// <summary>
	/// Description of voteForm.
	/// </summary>
	public partial class voteForm : Form
	{
		pnlRviewChoice pCheck = new pnlRviewChoice();
		pnlCheck pCheckVote = new pnlCheck();
		
		public voteForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			pCheck.Name = "Check";
			pCheck.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(pCheck);
		    
		    pCheckVote.Name = "CheckVote";
			pCheckVote.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(pCheckVote);
		    
		    HandleControl("CheckVote");
		   
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
			ShowControl("Check");
		}
		
		void PnlBodyPaint(object sender, PaintEventArgs e)
		{
	
		}
		
		
		
		
	}
}
