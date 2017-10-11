using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
   public class certificate_details
    {
        //        certificatecanv_id integer,
        //certificate_detailsnum integer NOT NULL,
        //  stud_id integer,
        //  total_votes integer NOT NULL,

        int certicatecanv_id;

        public int Certicatecanv_id
        {
            get { return certicatecanv_id; }
            set { certicatecanv_id = value; }
        }
        int certificate_Detailsnum;

        public int Certificate_Detailsnum
        {
            get { return certificate_Detailsnum; }
            set { certificate_Detailsnum = value; }
        }
        int stud_id;

        public int Stud_id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }
        int total_votes;

        public int Total_votes
        {
            get { return total_votes; }
            set { total_votes = value; }
        }


    }
    public class ObjCertificate_details : certificate_details
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
