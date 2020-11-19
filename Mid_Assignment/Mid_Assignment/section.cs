using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class section
    {
         String name;
        faculty FacultyName;

        public string SectionName
        {
            get { return name; }
            set { name = value; }
        }
        public section(string sectionName)
        {
            this.name = sectionName;
        }

        public void AddTeacher(faculty teacherName)
        {
            if (teacherName.Counttime < 21)
            {
                this.FacultyName = teacherName;
            }
            else
            {
                Console.WriteLine("course can't add");
            }

        }

        public void ShowDetails()
        {
            Console.WriteLine("Section:" + name);
            FacultyName.ShowFInfo();
        }

    }
}
