using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using System.Windows.Forms;
using System.Data;

namespace votingLibrary
{
    public class Student
    {
        //stud_id integer NOT NULL,
        //voter_id integer NOT NULL,
        //dept_id integer,
        //first_name character varying(20) NOT NULL,
        //mid_init character(10),
        //last_name character varying(20) NOT NULL,
        //course_id integer,

        int voter_id;

        public int Voter_id
        {
            get { return voter_id; }
            set { voter_id = value; }
        }

        String first_name;

        public String First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        char mid_init;

        public char Mid_init
        {
            get { return mid_init; }
            set { mid_init = value; }
        }
        String last_name;

        public String Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        } 
        int dept_id;

        public int Dept_id
        {
            get { return dept_id; }
            set { dept_id = value; }
        }
     
        int course_id;

        public int Course_id
        {
            get { return course_id; }
            set { course_id = value; }
        }

        String fullname;

        public String Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }


        int stud_id;

        public int Stud_id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }

    }

    public class ObjStudent : Student
    {
        bggQueryPgSql query = new bggQueryPgSql();
        String yourString;
        public static bggQueryPgSql query1 = new bggQueryPgSql();
        public static String yourString1;
        public DataGridView GetAllStudent(DataGridView appGridView, string lastname, string firstname)
        {
            yourString = "Select * from student where last_name = '" + lastname + "' and first_name = '" + firstname + "'";
            return query.ViaDataGridView(yourString, appGridView);
        }
        
        
		public System.Windows.Forms.DataGridView GetAllStudent(DataGridView appGridView)
		{
			this.yourString = "select student.stud_id as Student_id, student.first_name || ',' || student.last_name as Name, student.year_level as Year_Lvl, course.course_name as Course_name from student left join course on course.course_id = student.course_id;";
			return this.query.ViaDataGridView(yourString, appGridView);
		}

        public int totalStudent()
        {
            yourString = "Select count(stud_id) from student";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public TextBox GetStudent(TextBox myTb)
        {
            yourString = "Select initcap(last_name) from student order by last_name";
            return query.ViaTextbox_AutoCompleteCustomSource(yourString, myTb);
        }

        public string GetAllNames()
         {
             yourString = "Select first_name||', '||last_name from student;";
             return query.ViaSingleData(yourString);
         }

        public int GetID()
        {
            yourString = "Select count(stud_id) from student;";
            return int.Parse(query.ViaSingleData(yourString));
        }


        public string GetNames(int student_id)
        {
            yourString = "Select last_name||', '||first_name from student where stud_id="+student_id+";";
            return query.ViaSingleData(yourString);
        }

        public int GetStud_id(int student_id)
        {
            yourString = "Select stud_id from student where stud_id = "+student_id+";";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public TextBox GetStudent1(TextBox myTb)
        {
            yourString = "Select initcap(first_name) from student order by first_name";
            return query.ViaTextbox_AutoCompleteCustomSource(yourString, myTb);
        }

        public string GetCandidateNames(String a,String name)
        {
            yourString = "select c.first_name||', '||c.last_name from all_positions a , candidate b , student c where a.position_id = b.position_id AND c.stud_id = b.student_id AND a.position_name='"+"Governor"+"';";
            return query.ViaSingleData(yourString);
        }
        public string GetProfileIDusingname(string name)
        {//Sebial, Roosevelt E
            //name = name.ToLower();
            string lname = null;
            string fname = null;
            bool a = true;
            foreach (char i in name)
            {
                if (a)
                {

                    if (i == ',')
                    {
                        a = false;
                    }
                    else
                    {
                        lname += i.ToString();
                    }
                }
                else
                {
                    fname += i.ToString();
                }
            }

            fname = fname.Remove(0, 1);
            fname = fname.Remove(fname.Length - 2, 2);
            string mi = name[name.Length - 1].ToString();
            

            Last_name = lname;
            First_name = fname;
            //Emp_mi = mi;
            yourString = "Select stud_id from student where last_name ='" + Last_name + "' and first_name = '" + First_name + "' ";
            return query.ViaSingleData(yourString);
        }
        int count;

        public int GetStudentID(string position_name)
        {
            yourString = "Select student.stud_id from student, candidate, all_positions where candidate.student_id = student.stud_id and candidate.position_id = all_positions.position_id and all_positions.position_name = '"+position_name+"';";
            return int.Parse(query.ViaSingleData(yourString));
        }

        public void getInfo(string inf)
        {
            yourString = inf;
           
        } 
        public string getInfo()
        {
            return query.ViaSingleData(yourString);
        }

        public bool UpdateStudent()
        {
            yourString = "Update student set first_name='"+First_name+"' , last_name = '"+Last_name+"', dept_id="+Dept_id+" , course_id="+Course_id+" where stud_id="+Stud_id+"";
           return query.InsertUpdateDelete(yourString);
        }
         
      
       public static int getid(String Full_name)
       {
           yourString1= "Select stud_id from student where first_name||', '||last_name='" +Full_name+ "'";
           return int.Parse(query1.ViaSingleData(yourString1));
       }

       public static String getName(int stud_id)
       {
           yourString1 = "Select first_name||', '||last_name from student where stud_id="+stud_id+"";
           return query1.ViaSingleData(yourString1);
       }

       public static int getvoterid(int stud_id)
       {
           yourString1 = "Select voter_id from student where stud_id=" + stud_id + ";";
           return int.Parse(query1.ViaSingleData(yourString1));
       }

         public static String getCollege(int stud_id)
       {
           yourString1 = "Select d.dept_name from student s , course c, department d where s.course_id = c.course_id and c.course_id = d.course_id and s.stud_id="+stud_id+";";
           return query1.ViaSingleData(yourString1);
       }

        public static String getCourse(int stud_id)
        {
            yourString1 = "Select c.course_name from course c, student s where s.course_id = c.course_id and s.stud_id ="+stud_id+";";
           return query1.ViaSingleData(yourString1);
        }

        
        public static String getYear()
        {
            yourString1 = "Select voter_id from student where stud_id ;";
           return query1.ViaSingleData(yourString1);
        }

        public int GettID(String fname, String lname)
        {
            yourString = "Select stud_id from student where first_name = '" + fname + "' and last_name='" + lname + "';";
            return int.Parse(query.ViaSingleData(yourString));
        }


        public int set(string tbfname, string tblname)
        {
            yourString = "Select stud_id from student where first_name= '" + tblname + "' and last_name = '" + tbfname + "';";
            Console.WriteLine(yourString);
            return int.Parse(query.ViaSingleData(yourString));
        }

        public int Getstudid(String fullname)
        {
            yourString = "Select stud_id from student where first_name||', '||last_name ='" + fullname + "';";
            Console.WriteLine(yourString);
            return int.Parse(query.ViaSingleData(yourString));
        }
       }
}
