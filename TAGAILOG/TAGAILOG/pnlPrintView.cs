/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/18/17
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using FastReport;
using votingLibrary;
namespace TAGAILOG
{
	/// <summary>
	/// Description of pnlPrintView.
	/// </summary>
	public partial class pnlPrintView : UserControl
	{
		Objcandidate oc = new Objcandidate();
		public pnlPrintView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			UpdateGv();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void UpdateGv()
		{	
			dataitems = oc.GetAllCandidate(dataitems);
			DataGridViewColumn column1 = dataitems.Columns[0];
			column1.Width = 50;
			dataitems.Columns[0].HeaderText = "ID";
			DataGridViewColumn column2 = dataitems.Columns[1];
			column2.Width = 135;
			dataitems.Columns[1].HeaderText = "Candidate ID";
			DataGridViewColumn column3 = dataitems.Columns[2];
			column3.Width = 200;
			dataitems.Columns[2].HeaderText = "NAME";
			DataGridViewColumn column4 = dataitems.Columns[3];
			column4.Width = 100;

		}
		
		void DataitemsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		void Button1Click(object sender, EventArgs e)
		{
		    Print_CertificateCanvList canv = new Print_CertificateCanvList();
            canv.Design();
            canv.Show();
		}
	}
}
