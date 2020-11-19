using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to University Management System");
            Console.WriteLine();

            Console.WriteLine("Developed by Piu Terasa Costa");
            Console.WriteLine();

            Console.WriteLine("Developer At Kuratoli Software Solutions");

            Console.WriteLine("..........................................");
            Console.WriteLine("..........................................");
            Console.WriteLine();

            department cse = new department("CSE");
            department bba = new department("BBA");
            department eee = new department("EEE");
            department csse = new department("CSSE");


            course oop2 = new course("OOP2", "3012");
            course oop1 = new course("JAVA", "3011");
            course pl = new course("PROGRAMING LANGUAGE ", "3010");
            course acc = new course("Accounting", "2050");
            course device = new course("Electronic Device ", "3070");


            


            csse.AddCourse(oop2);
            cse.AddCourse(oop1);
           eee.AddCourse(pl);
            eee.AddCourse(device);
            bba.AddCourse(acc);

            section A = new section("A");
            section B = new section("B");
            section C = new section("C");
            section D = new section("D");
            section E = new section("E");
            section H = new section("H");

            oop2.AddSection(A);
            oop1.AddSection(B);
            pl.AddSection(C);
            device.AddSection(D);
            acc.AddSection(E);
            oop1.AddSection(H);



            faculty F = new faculty("Tanvir Ahmed", "17-98635-2", 15);
            faculty F1 = new faculty("Rumana Afrin ", "15-75474-8", 14);
            faculty F2 = new faculty("Bisshawjit Banik ", "17-854739-2", 12);
            faculty F3 = new faculty("Kaniz Fatema ", "17-89653-2", 15);
            F.AddSection(A);
            F.AddSection(B);
            F1.AddSection(E);
            F2.AddSection(D);
            F3.AddSection(C);
            F3.AddSection(H);




            A.AddTeacher(F);
            B.AddTeacher(F);
            C.AddTeacher(F3);
            D.AddTeacher(F2);
            E.AddTeacher(F1);
            H.AddTeacher(F3);


            Console.WriteLine();


            Console.WriteLine("..........Information of faculty sectionwise ...........");
            oop1.ShowSectionFaculty();
            oop2.ShowSectionFaculty();
            pl.ShowSectionFaculty();
            acc.ShowSectionFaculty();
            device.ShowSectionFaculty();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(".......INFORMATION OF SECTIONS FACULTYWISE....." );
            Console.WriteLine();



            F.ShowSectionDetails();
            F1.ShowSectionDetails();
            F2.ShowSectionDetails();
            F3.ShowSectionDetails();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("........COURSE DETAILS.......");
            Console.WriteLine();

            oop1.ShowInfo();
            oop2.ShowInfo();
            pl.ShowInfo();
            acc.ShowInfo();
            device.ShowInfo();

        }

    }
}

