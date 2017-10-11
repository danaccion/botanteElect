using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;

namespace votingLibrary 
{
    public class partylist_candidate
    {
        //        partylist_id integer NOT NULL,
        //dept_id integer,
        //  position_id integer,
        //  partylist_name character varying(20),
        //  platfrom text,

        int partylist_id;

        public int Partylist_id
        {
            get { return partylist_id; }
            set { partylist_id = value; }
        }
        int dept_id;

        public int Dept_id
        {
            get { return dept_id; }
            set { dept_id = value; }
        }
        int position_id;

        public int Position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }
        String partylist_name;

        public String Partylist_name
        {
            get { return partylist_name; }
            set { partylist_name = value; }
        }
        String platfrom;

        public String Platfrom
        {
            get { return platfrom; }
            set { platfrom = value; }
        }



    }

    public class ObjPartylist_Candidate: partylist_candidate
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
