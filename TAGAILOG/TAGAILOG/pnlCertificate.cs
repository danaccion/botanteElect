/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/09/17
 * Time: 6:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using votingLibrary;

namespace TAGAILOG
{
	/// <summary>
	/// Description of pnlCertificate.
	/// </summary>
	public partial class pnlCertificate : UserControl
	{
		Objcandidate oc = new Objcandidate();
		public pnlCertificate()
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
			dataitems.Columns[1].HeaderText = "NAME";
			DataGridViewColumn column3 = dataitems.Columns[2];
			column3.Width = 200;
			dataitems.Columns[2].HeaderText = "YEAR LEVEL";
			DataGridViewColumn column4 = dataitems.Columns[3];
			column4.Width = 100;

		}
		
		void DataitemsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
	}
}
