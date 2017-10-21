/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/10/17
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAGAILOG
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Usr_Home home = new Usr_Home();
		pnlSetCandidate setCandidate = new pnlSetCandidate();
		pnlViewCandidate ViewCandidate = new pnlViewCandidate();
		pnlCertificate Certificate = new pnlCertificate();
		pnlSetPartylist SetPartyList = new pnlSetPartylist();
		pnlViewStudents viewStudents = new pnlViewStudents();
		pnlPrintView pView = new pnlPrintView();
		pnlSetCand setCand = new pnlSetCand();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			home.Name = "Home";
			home.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(home);
		    
		    ViewCandidate.Name = "VCandidate";
		    ViewCandidate.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(ViewCandidate);	  
		    
		    setCandidate.Name = "setCandidate";
		    setCandidate.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(setCandidate);
		    
		    Certificate.Name = "Certificate";
		    Certificate.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(Certificate);
		    
		    SetPartyList.Name = "setPartyList";
		    SetPartyList.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(SetPartyList);
		    
		    viewStudents.Name = "viewStudents";
		    SetPartyList.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(viewStudents);
		    
		    pView.Name = "view";
		    pView.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(pView);
		    
		    setCand.Name = "setCand";
		    setCand.Dock = DockStyle.Fill;
		    pnlBody.Controls.Add(setCand);
		    
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
		
		void PnlBodyPaint(object sender, PaintEventArgs e)
		{
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			ShowControl("VCandidate");
		}
		void Button2Click(object sender, EventArgs e)
		{
			ShowControl("viewStudents");
		}
		void Button3Click(object sender, EventArgs e)
		{
			ShowControl("setCandidate");
		}
		void Button4Click(object sender, EventArgs e)
		{
			ShowControl("setPartyList");
		}
		void Button5Click(object sender, EventArgs e)
		{
			ShowControl("view");
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
	}
}
