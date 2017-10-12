/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/10/17
 * Time: 9:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using votingLibrary;
using bggPgSql;

namespace TAGAILOG
{
	/// <summary>
	/// Description of pnlViewCandidate.
	/// </summary>
	public partial class pnlViewCandidate : UserControl
	{
	
		Objcandidate oc = new Objcandidate();
		public pnlViewCandidate()
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
		void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		
		void UpdateGv()
		{	
			dataitems = oc.GetAllCandidate(dataitems);
			DataGridViewColumn column1 = dataitems.Columns[0];
			column1.Width = 100;
			dataitems.Columns[0].HeaderText = "ID";
			DataGridViewColumn column2 = dataitems.Columns[1];
			column2.Width = 100;
			dataitems.Columns[1].HeaderText = "Candidate ID";
			DataGridViewColumn column3 = dataitems.Columns[2];
			column3.Width = 345;
			dataitems.Columns[2].HeaderText = "NAME";
			DataGridViewColumn column4 = dataitems.Columns[3];
			column4.Width = 345;
			dataitems.Columns[3].HeaderText = "POSITION";
		}

	}
}
