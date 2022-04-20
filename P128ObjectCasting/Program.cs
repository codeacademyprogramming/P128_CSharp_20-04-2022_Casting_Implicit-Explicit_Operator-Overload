using P128ObjectCasting.Modesl;
using System;

namespace P128ObjectCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human ins1 = new Human();

            //ins1.Name = "Hikmet";
            //ins1.SurName = "Abbasov";

            //Console.WriteLine(ins1);

            //Boxing
            //Developer developer = new Developer();

            //Human student = developer;

            //Test(developer);

            Developer developer1 = new Developer();
            Developer developer2 = new Developer();

            Teacher teacher1 = new Teacher();
            teacher1.InstructorType = "Programming";
            Teacher teacher2 = new Teacher();
            teacher2.InstructorType = "Design";

            Enginieer enginieer1 = new Enginieer();
            Enginieer enginieer2 = new Enginieer();

            Student[] students = { developer1, developer2, teacher1, teacher2, enginieer1, enginieer2 };

            Test(students);
        }

        //Unboxing
        static void Test(Student[] students)
        {
            //Bu Cur Bir Basa UnBoxing Tehlukelidi
            //Teacher teacher = (Teacher)students[0];

            //Console.WriteLine(teacher.InstructorType);

            //bool check = students[2] is Teacher;

            //Console.WriteLine(check);
            //Safety Way v1 with is operator (true/false)
            //foreach (Student student in students)
            //{
            //    if (student is Teacher)
            //    {
            //        Teacher teacher = (Teacher)student;
            //        Console.WriteLine(teacher.InstructorType);
            //    }
            //    else if (student is Developer)
            //    {
            //        Developer developer = (Developer)student;
            //        Console.WriteLine("Developer");
            //    }
            //    else if (student is Enginieer)
            //    {
            //        Enginieer enginieer = (Enginieer)student;
            //        Console.WriteLine("Enginieer");
            //    }
            //}

            //Safety Way v2 with as operator (can conver get object / null)

            //Teacher teacher = students[2] as Teacher;

            //Console.WriteLine(teacher.InstructorType);

            foreach (Student student in students)
            {
                Teacher teacher = student as Teacher;
                Developer developer = student as Developer;
                Enginieer enginieer = student as Enginieer;

                if (teacher != null)
                {
                    Console.WriteLine(teacher.InstructorType);
                }
                else if (developer != null)
                {
                    Console.WriteLine("Developer");
                }
                else if(enginieer != null)
                {
                    Console.WriteLine("Enginieer");
                }
            }

        }

        static void Test(Human human)
        {

        }
    }
}
