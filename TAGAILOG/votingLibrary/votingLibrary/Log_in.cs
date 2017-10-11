using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;

namespace votingLibrary
{
  //   access_id integer NOT NULL,
  //access_lvl character varying NOT NULL,
  //stud_id integer NOT NULL,
  //CONSTRAINT "Log_In_pkey" PRIMARY KEY (access_id),
  //CONSTRAINT "Log_In_stud_id_fkey" FOREIGN KEY (stud_id)
  //    REFERENCES student (stud_id) MATCH SIMPLE
  //    ON UPDATE NO ACTION ON DELETE NO ACTION
  public class Log_in
    {
        int access_id;

        public int Access_id
        {
            get { return access_id; }
            set { access_id = value; }
        }


        String access_lvl;

        public String Access_lvl
        {
            get { return access_lvl; }
            set { access_lvl = value; }
        }
      
     }

    public class ObjAccess : Log_in
    {
        bggQueryPgSql query = new bggQueryPgSql();
        String yourString;
        int count;

        public int StudentAccessID(String fullname,String password)
        {
            yourString = "Select count(L.access_id) from student S,log_in L where S.access_id = L.access_id AND S.first_name||', '||S.last_name ='"+fullname+"' and S.password='"+password+"';";
            count = Convert.ToInt16(query.ViaSingleData(yourString));
            return count;
        }


        public int StudentID(String fullname)
        {
            yourString = "Select L.access_id from student S where S.first_name||', '||S.last_name ='" + fullname + "';";
            count = Convert.ToInt16(query.ViaSingleData(yourString));
            return count;
        }
        public ComboBox GetAccess(ComboBox myTb)
        {
            yourString = "Select access_lvl from log_in";
            return query.ViaComboBox(yourString, myTb);
        }

        public int GetAccess_Id(String cmb)
        {
            yourString = "Select access_id from log_in where access_lvl = '"+cmb+"';";
            return int.Parse(query.ViaSingleData(yourString));
        }
    }
}
