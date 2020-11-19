using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class course
    {
         String courseName;
         String courseId;
        section[] sectionName = new section[5];
        int countSection = 0;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public course(string cn, string cid)
        {
            this.courseName = cn;
            this.courseId = cid;
        }

        public void AddSection(section sn)

        {

            this.sectionName[countSection++] = sn;
        }
        public void ShowSectionFaculty()
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
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Id Number : " + courseId);
            
        }


    }
}
