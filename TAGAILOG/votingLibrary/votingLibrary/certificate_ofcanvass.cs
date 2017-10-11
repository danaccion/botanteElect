using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Data;
using System.Windows.Forms;
namespace votingLibrary
{
    public class certificate_ofcanvass
    {
        //        certificatecanv_id integer NOT NULL,
        //staff_id1 integer,
        //  staff_id2 integer,
        //  date_startedtime date NOT NULL,
        //  date_endedtime date NOT NULL,
        //  numb_oftotalvoters integer NOT NULL,
        //  numb_oftotalactualvoters integer NOT NULL,
        //  numb_ofnotvoted integer,

        int certificatecanv_id;

        public int Certificatecanv_id
        {
            get { return certificatecanv_id; }
            set { certificatecanv_id = value; }
        }
        int staff_id1;

        public int Staff_id1
        {
            get { return staff_id1; }
            set { staff_id1 = value; }
        }
        int staff_id2;

        public int Staff_id2
        {
            get { return staff_id2; }
            set { staff_id2 = value; }
        }
        DateTime date_startedtime;

        public DateTime Date_startedtime
        {
            get { return date_startedtime; }
            set { date_startedtime = value; }
        }
        DateTime date_endedtime;

        public DateTime Date_endedtime
        {
            get { return date_endedtime; }
            set { date_endedtime = value; }
        }
        int numb_oftotalvoters;

        public int Numb_oftotalvoters
        {
            get { return numb_oftotalvoters; }
            set { numb_oftotalvoters = value; }
        }
        int numb_oftotalactualvoters;

        public int Numb_oftotalactualvoters
        {
            get { return numb_oftotalactualvoters; }
            set { numb_oftotalactualvoters = value; }
        }
        int numb_ofnotvoted;

        public int Numb_ofnotvoted
        {
            get { return numb_ofnotvoted; }
            set { numb_ofnotvoted = value; }
        }

    }

    public class Objcertificate_ofcanvass : certificate_ofcanvass
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;



        public DataGridView GetAllCandidate(DataGridView appGridView)
        {
            mystring = "select Distinct c.student_id as stud_id,partylist_id as party_id,s.last_name||', '||s.first_name as Names_of_Candidate ,a.position_name from candidate c,student s ,all_positions a where c.student_id = s.stud_id and a.position_id = c.position_id;";
            return query.ViaDataGridView(mystring, appGridView);
        }
        /*select student_id,partylist_id,b.last_name||', '||b.first_name, a.platform as Plat_form,c.total_votes Total_Votes from candidate a,student b,certificate_details c where a.student_id = b.stud_id AND
c.stud_id = b.stud_id AND b.last_name = 'Bonto';*/
        public DataGridView GetAllCandidate(DataGridView appGridView, string lastname)
        {
            mystring = "select student_id,partylist_id,b.last_name||', '||b.first_name as Name, a.platform as Plat_form from candidate a,student b,vote v  where a.student_id = b.stud_id AND b.last_name='" + lastname + "';";
            return query.ViaDataGridView(mystring, appGridView);
        }

        public DataTable GetMemberDetails(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id,S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, v.vote as Votes from student S,candidate C,all_positions A,vote v where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='Governor' AND S.stud_id = v.std_id ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails1(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id,S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A,vote v  where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='Vice-Governor' AND S.stud_id = v.std_id group by S.stud_id, S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails2(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name , count(v.vote) as Votes from student S,candidate C,all_positions A,vote v where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='Secretary' AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails3(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A ,vote v where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='treasurer' AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails4(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A ,vote v where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='auditor' AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails5(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A,vote v  where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='1yr representative' AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails6(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A,vote v  where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='2yr representative' AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails7(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A,vote v  where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='President'AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails8(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A,vote v  where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='Vice President'AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

        public DataTable GetMemberDetails9(DataTable myDt)
        {
            mystring = "Select S.stud_id as Stud_id, S.first_name||', '||S.last_name as Names_Of_Candidates,A.position_name as Position_Name, count(v.vote) as Votes from student S,candidate C,all_positions A,vote v  where S.stud_id = C.student_id AND C.position_id = A.position_id AND A.position_name ='Vice-Governor'AND S.stud_id = v.std_id group by S.stud_id,  S.first_name||', '||S.last_name,A.position_name,v.vote ;";
            return query.ViaDataTable(mystring, myDt);
        }

    }
}
