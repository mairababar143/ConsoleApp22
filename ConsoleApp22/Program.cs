using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            int option = 0, semester = 0;
            string studentID = " ", name = " ", department = " ", university = " ", attendance = " " ;
            float cgpa = 0;
            Console.Write("Main Menu\n\n1. Create New Student\n2. Search Student\n3. Delete Student Record\n4. List top 03 of class\n5. Mark student attendance\n6. View attendance\n\nOption: ");
            option = Convert.ToInt32(Console.ReadLine());
            student.GetInfo();

            switch(option)
            {
                case 1:
                    {
                        //Console.WriteLine("Check");
                        Console.Clear();
                        Console.WriteLine("Create New Student\n");
                        Console.Write("Enter the following information for a new student:\n\nStudent ID: ");
                        studentID = Console.ReadLine();
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Attendance: ");
                        attendance = Console.ReadLine();
                        Console.Write("CGPA: ");
                        cgpa = (float)Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Semester: ");
                        semester = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Department: ");
                        department = Console.ReadLine();
                        Console.Write("University: ");
                        university = Console.ReadLine();
                        student.NewStudent(name, attendance, cgpa, semester, department, university, studentID);
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
