using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;
namespace votingLibrary
{
   public class vote
    {
  //     stud_id integer NOT NULL,
  ////position_name character varying(1),
  //votes integer NOT NULL,
        int stud_id;

        public int Stud_id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }
        String position_name;

        public String Position_name
        {
            get { return position_name; }
            set { position_name = value; }
        }
        int votes;

        public int Votes
        {
            get { return votes; }
            set { votes = value; }
        }
    }
        
   public class Objvote : vote
   {
       bggQueryPgSql query = new bggQueryPgSql();
       string yourString;

       public bool insertVotes(int studid, String positionname,int votes)
       {
           yourString = "Insert into vote values ("+studid+",'"+positionname+"',"+votes+");";
           return query.InsertUpdateDelete(yourString);

       }

       public bool CastVotes(int studid)
       {
           yourString = "Update vote set votes = votes +1 where stud_id = " + studid + "";
           return query.InsertUpdateDelete(yourString);
       }

       public int countGov()
       {
           yourString = "Select count(candidate_id) from candidate where position_id=1";
           return int.Parse(query.ViaSingleData(yourString));
       }
   }
}
