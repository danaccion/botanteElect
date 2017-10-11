using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
   public class candidate_application
    {
        //candidate_id integer,
        //scope_id integer,
        //  qualification text,

        int candidate_id;

        public int Candidate_id
        {
            get { return candidate_id; }
            set { candidate_id = value; }
        }
        int scope_id;

        public int Scope_id
        {
            get { return scope_id; }
            set { scope_id = value; }
        }
        String qualification;

        public String Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }

    }
    public class Objcandidate_application : candidate_application
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
