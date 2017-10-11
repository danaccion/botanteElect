using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;
using System.Data;
namespace votingLibrary
{
    public class candidate
    {
        //      candidate_id integer NOT NULL,
        //      position_id integer,
        //partylist_id integer,
        //stud_id integer,
        //platform text,

        int candidate_id;

        public int Candidate_id
        {
            get { return candidate_id; }
            set { candidate_id = value; }
        }
        int position_id;

        public int Position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }
        int partylist_id;

        public int Partylist_id
        {
            get { return partylist_id; }
            set { partylist_id = value; }
        }
        int stud_id;

        public int Stud_id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }
        String platform;

        public String Platform
        {
            get { return platform; }
            set { platform = value; }
        }

    }
    public class Objcandidate : candidate
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string yourString;
        static bggQueryPgSql query1 = new bggQueryPgSql();
        public string container;

        public DataGridView GetAllCandidate(DataGridView appGridView, int pos_id)
        {
            yourString = "select S.first_name||', '||S.last_name as Name,A.position_name as Positions from student S,candidate C,all_positions A where S.stud_id = C.student_id AND C.position_id = A.position_id AND C.position_id =" + pos_id + ";";
            return query.ViaDataGridView(yourString, appGridView);
        }

        public DataGridView GetAllCandidate(DataGridView appGridView)
        {
            yourString = "Select s.stud_id as Student_id,c.candidate_id as Candidate_id,s.last_name||', '||s.first_name as Full_name ,a.position_name as position from student s,candidate c,all_positions a where s.stud_id = c.student_id and c.position_id = a.position_id;";
            return query.ViaDataGridView(yourString, appGridView);
        }


        public ListView GetAllCand(ListView appGridView)
        {
            yourString = "Select s.stud_id as Student_id,c.candidate_id as Candidate_id,s.last_name||', '||s.first_name as Full_name ,a.position_name as position from student s,candidate c,all_positions a where s.stud_id = c.student_id and c.position_id = a.position_id;";
            return query.ViaListView(yourString, appGridView);
        }

        public string GetID(int id, string pos)
        {
            yourString = "Select a.last_name||', 'a.first_name from student a,candidate b where a.stud_id = "+id+";";
            return query.ViaSingleData(yourString);
        }

        public int getStudent_id(int position_id)
        {
            yourString = "select student_id from all_positions from candidate where position_id=" + position_id + ";";
            return int.Parse(query.ViaSingleData(yourString));
        }


        public int GetPosition_id(int stud_id)
        {
            yourString = "Select position_id from candidate, student where student_id =" + stud_id + ";";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public int GetPosid(int pos_id)
        {
            yourString = "Select position_id from candidate where position_id =" + pos_id + ";";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public int GetPos_id(int pos_id)
        {
            yourString = "Select position_id from candidate where position_id =" + pos_id + ";";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public int GetPosition_Name(int id)
        {
            yourString = "Select position_name from all_positions where position_id =" + id + ";";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public int countCandidate(int position_id)
        {
            yourString = "select count(S.stud_id) from student S,candidate C,all_positions A where S.stud_id = C.candidate_id AND C.position_id ="+position_id+";";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public string getCandidate(string position_name , int candidate_id)
        {
            yourString = "select S.first_name||', '||S.last_name from student S,candidate C,all_positions A where S.stud_id = C.student_id AND C.candidate_id = "+candidate_id+" AND A.position_name = '"+position_name+"';";
            return query.ViaSingleData(yourString);
        }

        public bool getCandidatebool(string position_name , int stud_id)
        {
            yourString = "select S.first_name||', '||S.last_name from student S,candidate C,all_positions A where S.stud_id = C.student_id AND C.candidate_id = " + stud_id + " AND A.position_name = '" + position_name + "';";
            return true;
        }
        /////

        public int GetPosid(String pos_name)
        {
            yourString = "Select position_id from all_positions where position_name ='" + pos_name + "';";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public String getCandidate(int position_id)
        {
            yourString = "select S.first_name||','||S.last_name,A.position_name from student S,candidate C,all_positions A where S.stud_id = C.candidate_id AND C.position_id = " + position_id + ";";
            return query.ViaSingleData(yourString);
        }

        public bool setCandidate(int candidateid, int positionid, int partylist, string platform, int studid)
        {
            yourString = "Insert into candidate values (" + candidateid + ", " + positionid + "," + partylist + ",'" + platform + "'," + studid + ");";
            return query.InsertUpdateDelete(yourString);

        }

        public int GenerateCandidate_ID()
        {
            container = "Select coalesce(max(candidate_id),0) + 1 from candidate";
            return int.Parse(query1.ViaSingleData(container));
        }


    }
}
