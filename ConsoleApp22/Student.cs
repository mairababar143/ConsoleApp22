using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp22
{
    class Student
    {
        float cgpa;
        int semester;
        string name, department, university, attendance, studentID;
        List<Student> listObject;

        public Student()
        {
            cgpa = 0;
            semester = 0;
            name = department = university = attendance = studentID = " ";
            listObject = new List<Student>();
        }

        public void GetInfo()
        {
            string line = " ";
            System.IO.StringReader file = new System.IO.StringReader(@"D:\Desktop\Student.txt");
            while((line = file.ReadLine()) != null)
            {
                studentID = line;
                name = file.ReadLine();
                attendance = file.ReadLine();
                cgpa = (float)Convert.ToDecimal(file.ReadLine());
                semester = Convert.ToInt32(file.ReadLine());
                department = file.ReadLine();
                university = file.ReadLine();
                listObject.Add(new Student() { studentID = this.studentID, name = this.name, attendance = this.attendance, cgpa = this.cgpa, semester = this.semester, department = this.department, university = this.university });
            }
            file.Close();
        }

        public void NewStudent(string n, string a, float c, int s, string d, string u, string id)
        {
            listObject.Add(new Student() { studentID = id, name = n, attendance = a, cgpa = c, semester = s, department = d, university = u });
            StreamWriter write;
            using (write = new StreamWriter(@"D:\Desktop\Student.txt", true))
            {
                write.WriteLine(id+"\n"+n+"\n"+a+"\n"+c+"\n"+s+"\n"+d+"\n"+u);
            }
            Console.WriteLine("List Name: {0}", listObject[0].name);
        }
        

    }
}
