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
            while ((line = file.ReadLine()) != null)
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

        public int CheckStudent(string id)
        {
            int index = 0, check = 0;
            for (int i = 0; i < listObject.Count(); i++)
            {
                if (listObject[i].studentID == id)
                {
                    index = i;
                    check++;
                }
            }
            if (check > 0)
                return index;
            else
                return -1;
        }
        public void NewStudent(string n, string a, float c, int s, string d, string u, string id)
        {
            listObject.Add(new Student() { studentID = id, name = n, attendance = a, cgpa = c, semester = s, department = d, university = u });
            StreamWriter write;
            using (write = new StreamWriter(@"D:\Desktop\Student.txt", true))
            {
                write.WriteLine(id + "\n" + n + "\n" + a + "\n" + c + "\n" + s + "\n" + d + "\n" + u);
            }
            Console.WriteLine("List Name: {0}", listObject[0].name);
        }
        public void SearchStudentID(string id)
        {
            int index = CheckStudent(id);
            if (index == -1)
                Console.WriteLine("Student Not Found");
            else
            {
                Console.WriteLine("Student Information\n\nID: {0}\nName: {1}\nCGPA: {2}\nSemester: {3}\nDepartment: {4}\nUniversity: {5}", listObject[index].studentID, listObject[index].name, listObject[index].cgpa, listObject[index].semester, listObject[index].department, listObject[index].university);
            }
        }
        public void SearchStudentName(string name)
        {
            int check = 0, index = 0;
            for (int i = 0; i < listObject.Count(); i++)
            {
                string listName = listObject[i].name.Substring(0, name.Length);
                if (name == listName)
                {
                    check++;
                    index = i;

                }
            }
            if (check > 0)
                Console.WriteLine("Student Information\n\nID: {0}\nName: {1}\nCGPA: {2}\nSemester: {3}\nDepartment: {4}\nUniversity: {5}", listObject[index].studentID, listObject[index].name, listObject[index].cgpa, listObject[index].semester, listObject[index].department, listObject[index].university);
            else
                Console.WriteLine("Student NOt Found");
        }
        public void DeleteStudent(string id)
        {
            int index = CheckStudent(id), fIndex = 0;
            if (index != -1)
            {
                listObject.RemoveAt(index);
                string[] fileLine = File.ReadAllLines(@"D:\Desktop\Student.txt");
                List<string> delList = new List<string>(fileLine);
                File.Delete(@"D:\Desktop\Student.txt");
                for (int i = 0; i < fileLine.Length; i++)
                {
                    if (fileLine[i] == id)
                    {
                        fIndex = i;
                    }
                }
                delList.RemoveRange(fIndex, 7);

                using (StreamWriter write = File.AppendText(@"D:\Desktop\Student.txt"))
                {
                    foreach (string element in delList)
                    {
                        write.WriteLine(element);
                    }
                }
            }
            else
                Console.WriteLine("Student not found");
        }
        public void MarkAttendance()
        {
            int index = 2;
            string[] array = File.ReadAllLines(@"D:\Desktop\Student.txt");
            for (int i = 0; i < listObject.Count(); i++)
            {
                char attendance = ' ';
                Console.Write(listObject[i].studentID+"\t"+listObject[i].name+"\t\tAttendance: ");
                attendance = Convert.ToChar(Console.ReadLine());
                if (attendance == 'p' || attendance == 'P')
                {
                    listObject[i].attendance = "Present";
                    array[index] = "P";
                }
                else if (attendance == 'a' || attendance == 'A')
                {
                    listObject[i].attendance = "Absent";
                    array[index] = "A";
                }
                else
                    Console.WriteLine("Incorrect Input");
                index += 7;
            }
            File.WriteAllLines(@"D:\Desktop\Student.txt", array);
        }
    }
}
 