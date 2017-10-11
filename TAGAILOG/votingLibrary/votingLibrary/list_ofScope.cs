using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
    public class list_ofScope
    {
        //        scope_id integer NOT NULL,
        //scope character varying(20) NOT NULL,

        int scope_id;

        public int Scope_id
        {
            get { return scope_id; }
            set { scope_id = value; }
        }
        String scope;

        public String Scope
        {
            get { return scope; }
            set { scope = value; }
        }

         
    }


    public class ObjList_of_Scope : list_ofScope
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
