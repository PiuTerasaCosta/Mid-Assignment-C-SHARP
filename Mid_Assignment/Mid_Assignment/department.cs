using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class department
    {
         String departmentName;
        course[] courseName = new course[100];
         int countCourse = 0;

        public String DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void ShowDInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void AddCourse(course courseName)
        {
            this.courseName[countCourse++] = courseName;
        }

    }
}
