/*
 * Created by SharpDevelop.

 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using FastReport;
using bggPgSql;
using votingLibrary;
namespace votingLibrary
{
    public class Print_CertificateCanvList
    {
        #region Declarations
        Objcertificate_ofcanvass report = new Objcertificate_ofcanvass();
        FastReport.Report rpt = new Report();
        DataSet ds;
        DataTable certificateTab;
        DataSet ds1;
        DataTable certificateTab1;
        DataSet ds2;
        DataTable certificateTab2;
        DataSet ds3;
        DataTable certificateTab3;
        DataSet ds4;
        DataTable certificateTab4;
        DataSet ds5;
        DataTable certificateTab5;
        DataSet ds6;
        DataTable certificateTab6;
        DataSet ds7;
        DataTable certificateTab7;
        DataSet ds8;
        DataTable certificateTab8;
        DataSet ds9;
        DataTable certificateTab9;
        #endregion
        public Print_CertificateCanvList()
        {
            createDatasets();
            LoadReport();
        }
        public void createDatasets()
        {
            ds = new DataSet();
            certificateTab = new DataTable();
            certificateTab = report.GetMemberDetails(certificateTab);
            ds.Tables.Add(certificateTab);
            certificateTab.TableName = "certificate_ofcanvass";

            ds1 = new DataSet();
            certificateTab1 = new DataTable();
            certificateTab1 = report.GetMemberDetails1(certificateTab1);
            ds.Tables.Add(certificateTab1);
            certificateTab1.TableName = "certificate_ofcanvass1";

            ds2 = new DataSet();
            certificateTab2 = new DataTable();
            certificateTab2 = report.GetMemberDetails2(certificateTab2);
            ds2.Tables.Add(certificateTab2);
            certificateTab2.TableName = "certificate_ofcanvass2";

            ds3 = new DataSet();
            certificateTab3 = new DataTable();
            certificateTab3 = report.GetMemberDetails3(certificateTab3);
            ds3.Tables.Add(certificateTab3);
            certificateTab3.TableName = "certificate_ofcanvass3";

            ds4 = new DataSet();
            certificateTab4 = new DataTable();
            certificateTab4 = report.GetMemberDetails4(certificateTab4);
            ds4.Tables.Add(certificateTab4);
            certificateTab4.TableName = "certificate_ofcanvass4";

            ds5 = new DataSet();
            certificateTab5 = new DataTable();
            certificateTab5 = report.GetMemberDetails5(certificateTab5);
            ds5.Tables.Add(certificateTab5);
            certificateTab5.TableName = "certificate_ofcanvass5";

            ds6 = new DataSet();
            certificateTab6 = new DataTable();
            certificateTab6 = report.GetMemberDetails6(certificateTab6);
            ds6.Tables.Add(certificateTab6);
            certificateTab6.TableName = "certificate_ofcanvass6";

            ds7 = new DataSet();
            certificateTab7 = new DataTable();
            certificateTab7 = report.GetMemberDetails7(certificateTab7);
            ds7.Tables.Add(certificateTab7);
            certificateTab7.TableName = "certificate_ofcanvass7";

        }

        public void LoadReport()
        {
            string location = @"Report/Certificateofcanv.frx";
            rpt.Load(location);
            rpt.RegisterData(ds);
            rpt.RegisterData(ds1);
            rpt.RegisterData(ds2);
            rpt.RegisterData(ds3);
            rpt.RegisterData(ds4);
            rpt.RegisterData(ds5);
            rpt.RegisterData(ds6);
            rpt.RegisterData(ds7);
            rpt.RegisterData(ds8);
            rpt.RegisterData(ds9);
            rpt.GetDataSource("certificate_ofcanvass").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass1").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass2").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass3").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass4").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass5").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass6").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass7").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass8").Enabled = true;
            rpt.GetDataSource("certificate_ofcanvass9").Enabled = true;

        }


        public void Design()
        {
            rpt.Design();
        }
        public void Show()
        {
            FastReport.Utils.Config.PreviewSettings.Buttons = PreviewButtons.All & ~PreviewButtons.Edit & ~PreviewButtons.Email & ~PreviewButtons.Open & ~PreviewButtons.Outline & ~PreviewButtons.PageSetup & ~PreviewButtons.Watermark;
            rpt.Show();
        }

        public FastReport.Report Get_report()
        {
            return rpt;
        }
        public void PrintBatch()
        {
            //string path = Application.StartupPath;
            rpt.PrintSettings.ShowDialog = false;
            rpt.Prepare();
            rpt.PrintPrepared();
        }
    }
}
