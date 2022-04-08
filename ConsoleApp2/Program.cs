using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ObjectOrientedProgrammingCourse
{
    public class Student
    {
        public string StudentName;
        public string StudentID;
        public string IdentificationCard;
        public Decimal mark;

        public Student(string Name, string ID, string IC, decimal mark)
        {
            this.StudentName = Name;
            this.StudentID = ID;
            this.IdentificationCard = IC;
            this.mark = mark;
        }
        public string Name
        {
            get { return this.StudentName; }
        }
        public string ID
        {
            get { return (string)this.StudentID; }
        }
        public string IC
        { get { return (string)this.IdentificationCard; } }

        public decimal Mark
        { get { return (decimal)this.mark; } }

    }
    public class detail
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("song", "BCS123", "123", 50));
            students.Add(new Student("wong", "BCS124", "124", 80));
            students.Add(new Student("kong", "BCS125", "125", 70));
            students.Add(new Student("lin", "BCS126", "126", 60));
            students.Add(new Student("chia", "BCS127", "127", 50));

            void DisplayAllStudentDetails(List<Student> std)
            {

                std.Sort((p1, p2) => string.Compare(p1.Name, p2.Name));
                Console.WriteLine("Student Details");

                foreach (Student p in std)
                {
                    Console.WriteLine("\t" + p.Name + "\t\t\t" + p.ID+"\t"+ p.IC);
                }


            }

            void DisplayAllStudentRanking(List<Student> std)
            {
                std.Sort((p1, p2) => p2.mark.CompareTo(p1.mark));

                Console.WriteLine("Student Ranking");

                foreach (Student p in std)
                {
                    Console.WriteLine("\t" + p.mark + "\t\t\t" + p.Name);
                }
            }

            DisplayAllStudentDetails(students);
            DisplayAllStudentRanking(students);

            Console.ReadLine();
        }
        
    }
    
    

       

    




}
    
       
    



