using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class totalteachinghour
    {
        public String CourseName { get; set; }
        public int CourseCreditNumber { get; set; }
        public department Departments { get; set; }
        course[] courses;
        public int CreditCount { get; set; }
        public totalteachinghour()
        {
            courses = new course[5];
        }
        public totalteachinghour(string courseName, int courseCreditNumber, department departments)
        {
            CourseName = courseName;
            CourseCreditNumber = courseCreditNumber;
            Departments = departments;
            courses = new course[5];
        }
        public void AddTeachingHours(params course[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 7)
                    this.courses[CreditCount++] = course;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNumber);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowInfo();
            }
        }

    }
}
