using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
    public class Staff
    {
        //staff_id integer NOT NULL,
        //stud_id integer,
        //dept_id integer,
        //staff_positions character varying(20) NOT NULL,

        int staff_id;

        public int Staff_id
        {
            get { return staff_id; }
            set { staff_id = value; }
        }
        int stud_id;

        public int Stud_id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }
        int dept_id;

        public int Dept_id
        {
            get { return dept_id; }
            set { dept_id = value; }
        }
        String Staff_positions;

        public String Staff_positions1
        {
            get { return Staff_positions; }
            set { Staff_positions = value; }
        }

    }

    public class ObjStaff : Staff
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string mystring;
    }
}
