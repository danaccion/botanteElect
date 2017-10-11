using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
    public class position_scope
    {
        //scope_id integer,
        //term character varying(20) NOT NULL,

        int scope_id;

        public int Scope_id
        {
            get { return scope_id; }
            set { scope_id = value; }
        }
        String term;

        public String Term
        {
            get { return term; }
            set { term = value; }
        }

    }

    public class ObjPosition_Scope : position_scope
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
