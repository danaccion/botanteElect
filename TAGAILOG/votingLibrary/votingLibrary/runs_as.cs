using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
    public class runs_as
    {
        //partystudent_id integer NOT NULL,
        //partylist_id integer,
        //stud_id integer,
        //runs_date date NOT NULL,

        int partystudent_id;

        public int Partystudent_id
        {
            get { return partystudent_id; }
            set { partystudent_id = value; }
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
        DateTime runs_date;

        public DateTime Runs_date
        {
            get { return runs_date; }
            set { runs_date = value; }
        }

    }

    public class ObjRuns_as : runs_as
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
