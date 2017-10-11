/*
 * Created by SharpDevelop.
 * User: Ricardo
 * Date: 7/30/2014
 * Time: 8:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using bggPgSql;
using System.Globalization;

namespace votingLibrary
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class QueryMemberMaster
	{
		/*CREATE TABLE member_master
(
  member_id character varying(15) NOT NULL,
  member_fname character varying,
  member_lname character varying,
  member_mi character(1),
  member_address character varying,
  member_bday date,
  member_tin character varying,
  member_sss character varying,
   member_gender character varying,
  member_spouse character varying,
  member_civilstatus character varying,
  member_status boolean,
  CONSTRAINT member_master_pkey PRIMARY KEY (member_id )
)*/
		string myString;
		bggQueryPgSql myQuery = new bggQueryPgSql();
		//repeatedFunction repfunc = new repeatedFunction();
		public bool Insert(string memid)
		{
			myString = "Insert into member_master(member_id) values('"+memid+"')";
			return myQuery.InsertUpdateDelete(myString);
		}
		
	/*	public string GenerateIdNew(string lastname, Random rnd)
		{
			myString = "Select count(*) from member_master where member_id=";
			return repfunc.Generate_IdRandom(myString, lastname, rnd);
		}*/
		
		public bool Updatemember_fname(string mem_id, string member_fname)
		{
			myString = "Update member_master set member_fname = '"+member_fname+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_lname(string mem_id, string member_lname)
		{
			myString = "Update member_master set member_lname = '"+member_lname+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_mi(string mem_id, string member_mi)
		{
			myString = "Update member_master set member_mi = '"+member_mi+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_address(string mem_id, string member_address)
		{
			myString = "Update member_master set member_address = '"+member_address+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_bday(string mem_id, string member_bday)
		{
			myString = "Update member_master set member_bday = '"+member_bday+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_tin(string mem_id, string member_tin)
		{
			myString = "Update member_master set member_tin = '"+member_tin+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_sss(string mem_id, string member_sss)
		{
			myString = "Update member_master set member_sss = '"+member_sss+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		
		public bool Updatemember_gender(string mem_id, string member_gender)
		{
			myString = "Update member_master set member_gender = '"+member_gender+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_spouse(string mem_id, string member_spouse)
		{
			myString = "Update member_master set member_spouse = '"+member_spouse+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public bool Updatemember_civilstatus(string mem_id, string member_civilstatus)
		{
			myString = "Update member_master set member_civilstatus = '"+member_civilstatus+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		
		public bool Updatmember_status(string mem_id, string member_status)
		{
			myString = "Update member_master set member_status = '"+member_status+"' where member_id = '"+mem_id+"'";
			return myQuery.InsertUpdateDelete(myString);	
		}
		public DataGridView GetMembers(DataGridView myGv, string status)
		{//id, member, gender, address,
			if(status=="all")
			{
				myString = "Select upper(member_id) as id, initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) as member, initcap(member_gender) as gender, initcap(member_address) as address, member_meterno  as meter_no from member_master order by member";
			}
			else
			{
				myString = "Select upper(member_id) as id, initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) as member, initcap(member_gender) as gender, initcap(member_address) as address, member_meterno  as meter_no from member_master where member_status = '"+status+"' order by member";
			}
			
			return myQuery.ViaDataGridView(myString, myGv);
				
		}
		public DataTable GetMembers(DataTable myGv, string status)
		{//id, member, gender, address,
			if(status=="all")
			{
				myString = "Select upper(member_id) as id, initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) as member, initcap(member_gender) as gender, initcap(member_address) as address, member_meterno  as meter_no from member_master order by member";
			}
			else
			{
				myString = "Select upper(member_id) as id, initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) as member, initcap(member_gender) as gender, initcap(member_address) as address, member_meterno  as meter_no from member_master where member_status = '"+status+"' order by member";
			}
			
			return myQuery.ViaDataTable(myString, myGv);
				
		}
		public DataGridView GetMembers(DataGridView myGv, string status, string textsearch)
		{//id, member, gender, address, 
			myString = "Select upper(member_id) as id, initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) as member, initcap(member_gender) as gender, initcap(member_address) as address, member_meterno  as meter_no from member_master where member_status = '"+status+"' and (lower(member_id) like '"+textsearch+"' or lower(member_lname) like '"+textsearch+"' or lower(member_fname) like '"+textsearch+"' or lower(member_mi) like '"+textsearch+"' or lower(member_address) like '"+textsearch+"' or lower(member_meterno) like '"+textsearch+"') order by member";
			return myQuery.ViaDataGridView(myString, myGv);
				
		}
		public DataTable GetMemberDetails(DataTable myDt, string mem_id)
		{
			myString = "Select * from student where stud_id = '"+1+"'";
			return myQuery.ViaDataTable(myString, myDt);
		}
		
		public TextBox GetEmployeeViaAutoComplete(TextBox myTb)
		{
			myString = "select initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) from member_master where member_status = 't' order by member_lname";
			return myQuery.ViaTextbox_AutoCompleteCustomSource(myString, myTb);
		}
		public TextBox GetMeterNoViaAutoComplete(TextBox myTb)
		{
			myString = "Select member_meterno from member_master order by member_meterno";
			return myQuery.ViaTextbox_AutoCompleteCustomSource(myString, myTb);
		}
		public string GetEmployeeCompleteName(string id)
		{
			myString = "select initcap(member_lname)||', '||initcap(member_fname)||' '||initcap(member_mi) from member_master where member_id = '"+id+"'";
			return myQuery.ViaSingleData(myString);
		}
		public string GetProfileIDusingname(string name)
		{//Sebial, Ricardo E
			name = name.ToLower();
			string lname=null;
			string fname=null;
			bool a = true;
			foreach(char i in name)
			{
				if(a)
				{
					
					if(i == ',')
					{
						a =false;
					}
					else
					{
						lname +=i.ToString();
					}
				}
				else
				{
					fname +=i.ToString();
				}
			}
			
			fname = fname.Remove(0,1);
			fname = fname.Remove(fname.Length-2, 2);
			string mi = name[name.Length-1].ToString();
			string Emp_lname;
			string Emp_fname;
			string Emp_mi;
			
			Emp_lname = lname;
			Emp_fname = fname;
			Emp_mi = mi;
			myString = "Select member_id from member_master where member_lname ='"+Emp_lname+"' and member_fname = '"+Emp_fname+"' and member_mi = '"+Emp_mi+"'";
			return myQuery.ViaSingleData(myString);
		}
		
		public bool CheckIfExists(string firstname, string lastname, string middleinitial)
		{
			myString = "Select count(*) from member_master where lower(trim(member_lname)) like '"+lastname+"' and lower(trim(member_fname)) like '"+firstname+"' and lower(trim(member_mi)) like '"+middleinitial+"'";
			return (int.Parse(myQuery.ViaSingleData(myString))>0?true:false);
		}
		
		public bool UpdateMeterNo(string memberid, string member_meterno)
		{
			myString = "Update member_master set member_meterno = '"+member_meterno+"' where member_id = '"+memberid+"'";
			return myQuery.InsertUpdateDelete(myString);
		}
		public string GetMemberIDUsingMeter(string member_meterno)
		{
			myString = "Select member_id from member_master where member_meterno = '"+member_meterno+"'";
			return myQuery.ViaSingleData(myString);
		}
		public string GetMeterNoUsingMemberID(string memberid)
		{
			myString = "select member_meterno from member_master where member_id = '"+memberid+"'";
			return myQuery.ViaSingleData(myString);
		}
		
		
	}
}