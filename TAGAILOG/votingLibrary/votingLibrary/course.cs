using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
   public  class course
    {
        //        course_id integer NOT NULL,
        //course_name character varying(20) NOT NULL,

        int course_id;

        public int Course_id
        {
            get { return course_id; }
            set { course_id = value; }
        }
        String course_name;

        public String Course_name
        {
            get { return course_name; }
            set { course_name = value; }
        }

        
    }

    public class Objcourse : course
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
