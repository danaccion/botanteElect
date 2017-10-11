using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;
namespace votingLibrary
{
    public class partylist
    {
  //        partylist_id integer NOT NULL,
  //dept_id integer,
  //position_id integer,
  //partylist_name character varying(20),
  //platfrom text,

        int partylist_id;

        public int Partylist_id
        {
            get { return partylist_id; }
            set { partylist_id = value; }
        }

        String partylist_name;

        public String Partylist_name
        {
            get { return partylist_name; }
            set { partylist_name = value; }
        }
        String platfrom;

        public String Platfrom
        {
            get { return platfrom; }
            set { platfrom = value; }
        }
    }

    public class ObjPartylist : partylist
    {
        bggQueryPgSql query = new bggQueryPgSql();
        string yourString;

        public bool Insert()
        {
            yourString = "Insert into partylist values ("+Partylist_id+", '" + Partylist_name + "', '" + Platfrom + "')";
            return query.InsertUpdateDelete(yourString);
        }

        public int GeneratePartylist_ID()
        {
            yourString = "Select coalesce(max(partylist_id),0) + 1 from partylist";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public void delete(int item)
        {
            yourString = "Delete from partylist where partylist_id ="+item+"";
            query.InsertUpdateDelete(yourString);
        }
  

        public ComboBox GetPartylist(ComboBox myTb)
        {
            yourString = "Select partylist_name from partylist";
            return query.ViaComboBox(yourString, myTb);
        }

        public int getpartylist_id(String partyListname)
        {
            yourString = "Select partylist_id from partylist where partylist_name = '" + partyListname + "'";
            return int.Parse(query.ViaSingleData(yourString));
        }

    }
}
