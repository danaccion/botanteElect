using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;

namespace votingLibrary
{
    //admin_id integer NOT NULL,
    // text NOT NULL,
    //password text NOT NULL,
    public class admin
    {
        int admin_id;

        public int Admin_id
        {
            get { return admin_id; }
            set { admin_id = value; }
        }

        String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }

    public class Objadmin : admin
    {
        bggQueryPgSql query = new bggQueryPgSql();
        String yourString;
        public int getAccess(String username,String password)
        {
            yourString = "Select count(admin_id) from admin where username = '" + username + "' and password = '" + password + "'";
            return int.Parse(query.ViaSingleData(yourString));
        }
    }
}
