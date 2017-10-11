/*
 * Created by SharpDevelop.
 * User: princejayaccion
 * Date: 08/23/17
 * Time: 7:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using bggPgSql;


namespace TAGAILOG
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		static void Main()
        {
            bggQueryPgSql conn = new bggQueryPgSql();
            conn.StartConnectionIni("" + Application.StartupPath + "/connection.ini");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
		
	}
}
