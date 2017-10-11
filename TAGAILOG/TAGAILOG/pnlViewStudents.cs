/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 09/10/17
 * Time: 1:09 PM
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
	/// Description of pnlViewStudents.
	/// </summary>
	public partial class pnlViewStudents : UserControl
	{
		ObjStudent os = new ObjStudent();
		public pnlViewStudents()
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
			dataitems = os.GetAllStudent(dataitems);
			DataGridViewColumn column1 = dataitems.Columns[0];
			column1.Width = 100;
			dataitems.Columns[0].HeaderText = "ID";
			
			DataGridViewColumn column2 = dataitems.Columns[1];
			column2.Width = 300;
			dataitems.Columns[1].HeaderText = "NAME";
			dataitems = os.GetAllStudent(dataitems);
			
			DataGridViewColumn column3 = dataitems.Columns[2];
			column3.Width = 250;
			dataitems.Columns[2].HeaderText = "YEAR LEVEL";
			dataitems = os.GetAllStudent(dataitems);
			
			DataGridViewColumn column4 = dataitems.Columns[3];
			column4.Width = 350;
			dataitems.Columns[3].HeaderText = "COURSE NAME";
			dataitems = os.GetAllStudent(dataitems);
			

			}
		
		void PnlViewStudentsLoad(object sender, EventArgs e)
		{
	
		}
		void DataitemsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
	}
}
