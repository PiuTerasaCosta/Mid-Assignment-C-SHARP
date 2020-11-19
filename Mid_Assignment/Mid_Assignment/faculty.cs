using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class faculty
    {
         String FacultyName;
        String FacultyId;
        public float Counttime;
        section[] sectionName = new section[5];
         int countSection = 0;

        public string TeacherName
        {
            get { return FacultyName; }
            set { FacultyName = value; }
        }

        public string TeacherId
        {
            get { return FacultyId; }
            set { FacultyId = value; }
        }

        public float TotalHourOfClass
        {
            get { return Counttime; }
            set { Counttime = value; }
        }
        public faculty(string teacherName, string teacherId, float totalHourOfClass)
        {
            this.FacultyName = teacherName;
            this.FacultyId = teacherId;
            this.Counttime = totalHourOfClass;
        }

        public void AddSection(section sectionName)
        {
            this.sectionName[countSection] = sectionName;
            countSection++;
            Counttime += 2.0f;
        }

        public void ShowFInfo()
        {
            Console.WriteLine("Teacher's Name: " + FacultyName);
            Console.WriteLine("Teacher's Id: " + FacultyId);
        }

        public void ShowSectionDetails()
        {
            for (int i = 0; i < 10; i++)
            {
                if (sectionName[i] != null)
                {
                    sectionName[i].ShowDetails();
                }
                else { break; }
            }
        }

    }
}
