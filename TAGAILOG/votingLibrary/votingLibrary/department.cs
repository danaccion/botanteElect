using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
    public class department
    {
        //        dept_id integer NOT NULL,
        //dept_name character varying(20) NOT NULL,
        //course_id integer,

        int dept_id;

        public int Dept_id
        {
            get { return dept_id; }
            set { dept_id = value; }
        }
        String dept_name;

        public String Dept_name
        {
            get { return dept_name; }
            set { dept_name = value; }
        }
        int course_id;

        public int Course_id
        {
            get { return course_id; }
            set { course_id = value; }
        }

    }

    public class ObjDepartment : department
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
