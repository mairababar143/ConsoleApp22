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
            int option1 = 0, semester = 0;
            string studentID = " ", name = " ", department = " ", university = " ", attendance = " " ;
            float cgpa = 0;
            Console.Write("Main Menu\n\n1. Create New Student\n2. Search Student\n3. Delete Student Record\n4. List top 03 of class\n5. Mark student attendance\n6. View attendance\n\nOption: ");
            option1 = Convert.ToInt32(Console.ReadLine());
            student.GetInfo();

            switch(option1)
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
                        int option = 0;
                        Console.Write("\tSearch Student\n\nSelect from the following:\n\t1. Search by ID\n\t2. Search by Name\n3. Display All Students\n\tOption: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (option)
                        {
                            case 1:
                                {
                                    string id = " ";
                                    Console.Write("\tSearch By ID\n\nEnter Student ID to Search\n\tID: ");
                                    id = Console.ReadLine();
                                    student.SearchStudentID(id);
                                    break;
                                }
                            case 2:
                                {
                                    string sName = " ";
                                    Console.Write("\tSearch By ID\n\nEnter Student Name to Search\n\tName: ");
                                    sName = Console.ReadLine();
                                    student.SearchStudentName(sName);
                                    break;
                                }
                            case 3:
                                {
                                    student.Display();
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        string id = " ";
                        Console.WriteLine("\tDelete Student\n");
                        Console.Write("Enter iD Of student to delete\n\tID: ");
                        id = Console.ReadLine();
                        student.DeleteStudent(id);
                        break;
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\tList top 3 Students\n");
                        student.TopThree();
                        break;
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("\tMark Student Attendance\n");
                        student.MarkAttendance();
                        break;
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("\tView Attendance\n");
                        student.ViewAttendance();
                        break;
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
