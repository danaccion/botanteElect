using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
namespace votingLibrary
{
    
    public class all_positions
    {
        //        position_id integer NOT NULL,
        //scope_id integer,
        //  position_name character varying(20),
        int position_id;

        public int Position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }
        int scope_id;

        public int Scope_id
        {
            get { return scope_id; }	
            set { scope_id = value; }
        }
        String position_name;

        public String Position_name
        {
            get { return position_name; }
            set { position_name = value; }
        }

     
    }
    public class Objall_positions : all_positions
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string yourString;

        public int GetPosition_id(String a)
        {
            yourString = "Select position_id from all_positions where position_name ='" + a + "';";
            return int.Parse(query.ViaSingleData(yourString));
        }
/*
        public ComboBox GetPosition(ComboBox myTb)
        {
            yourString = "Select initcap(position_name) from all_positions";
            return query.ViaComboBox(yourString, myTb);
        }*/
        public String GetPosition_Name(int positionid)
        {
            yourString = "Select position_name from all_positions where position_id =" + positionid + ";";
            return query.ViaSingleData(yourString);
        }
        public int GetPosition_id(int stud_id)
        {
            yourString = "Select position_id from all_positions where position_name ='" + stud_id + "';" ;
            return int.Parse(query.ViaSingleData(yourString));
        }

        public Boolean GetPositionNamebool(String a)
        {
            yourString = "Select position_name from all_positions where position_name ='" + a + "';";
            return true;
        }

        public String GetPositionName(String a)
        {
            yourString = "Select position_name from all_positions where position_name ='" + a + "';";
            return query.ViaSingleData(yourString);
        }

        public String GetPosName(int position_id)
        {
            yourString = "Select first_name||', '||last_name from candidate c,allpositions a where c.position_id ="+position_id+";";
            return query.ViaSingleData(yourString);
        }

        public String getPositionName(String fullname)
        {
            yourString = "select A.position_name from student S,candidate C,all_positions A where S.stud_id = C.student_id AND C.position_id = A.position_id AND S.first_name||''||last_name = '" + fullname + "';";
            return query.ViaSingleData(yourString);
        }

    }
}
    