using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;
namespace votingLibrary
{
   
  //  "Ballot_id" integer NOT NULL,
  //username text NOT NULL,
  //password text NOT NULL,
  //timestart timestamp without time zone NOT NULL,
  //CONSTRAINT ballot_pkey PRIMARY KEY ("Ballot_id")
    public class Ballot
    {
        int Ballot_id;
        public static int ballotid;
            public int Ballot_id1
        {
            get { return Ballot_id; }
            set { Ballot_id = value;
                  ballotid = value; }
        }

        String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        String password;


        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        DateTime timestart;

        public DateTime Timestart
        {
            get { return timestart; }
            set { timestart = value; }
        }

        DateTime timeEnd;

        public DateTime TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }
    }

    public class ObjBallot : Ballot
    {

        public static bggQueryPgSql query = new bggQueryPgSql();
        static String yourString;

        public int getAccess(String username, String password)
        {
            yourString = "Select count(ballot_id) from ballot where username='"+username+"' and password='"+password+"';";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public int getAccessballotid(String username)
        {
            yourString = "Select ballot_id from ballot where username='" + username + "';";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public static String getTimenow()
        {
            yourString = "Select clock_timestamp();";
            return query.ViaSingleData(yourString);
        }

        public DataGridView GetPos(DataGridView appGridView, String pos)
        {
            yourString = "Select student.first_name||', '||student.last_name as name , candidate.platform from student,candidate,all_positions where candidate.student_id=student.stud_id and candidate.position_id = all_positions.position_id and all_positions.position_name = '"+pos+"'";
            return query.ViaDataGridView(yourString, appGridView);
        }

        public String GetTimeStart(String time , int id)
        {
            yourString = "Update Ballot set timestart ='"+time+"' where ballot_id="+id+";";
            return query.ViaSingleData(yourString);
        }

        public  String GetTimeEnds(String time, int id)
        {
            yourString = "Update Ballot set timeend ='" + time + "' where ballot_id=" + id + ";";
            return query.ViaSingleData(yourString);
        }
        public int GetCount()
        {
            yourString = "Select counter from ballot;";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public bool Insert()
        {
            yourString = "Update ballot set counter=1";
            return query.InsertUpdateDelete(yourString);
        }

        public bool InsertStop()
        {
            yourString = "Update ballot set counter=2";
            return query.InsertUpdateDelete(yourString);
        }
    }
}
