using System;
using System.Collections.Generic;

namespace Curs6
{
    public  class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Identifier;

       
    }

    class Student : Person
    {
        public double GPA;
    
        public Student(string name,string surname,int age,string identifier,double gpa)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Identifier = identifier;
            GPA = gpa;
        }
        public string careerPath()
        {
            return "I am studying for my bachelor's degree";
        }
        public void printStudent()
        {
            Console.WriteLine($"Name: {Name} , Surname: {Surname} , Age: {Age} , Identifier: {Identifier} GPA: {GPA}");
        }
    }

    class Teacher : Person
    {
        public double Salary;

        public Teacher(string name, string surname, int age, string identifier, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Identifier = identifier;
            Salary = salary;
        }
        public string careerPath()
        {
            return "I am studying for my doctor's degree";
        }

        public void printTeacher()
        {
            Console.WriteLine($"Name: {Name} , Surname: {Surname} , Age: {Age} , Identifier: {Identifier} ,Salary: {Salary}");
        }


    }

    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student("Caleb", "Lanter", 22, "4901", 3.8);
            Student student2 = new Student("Asher", "Hext", 23, "2521", 2.4);
            Student student3 = new Student("Rae", "Cunningham", 22, "2398", 3.9);
            Student student4 = new Student("Max", "Denver", 23, "3219", 2.1);
            Student student5 = new Student("Owen", "Cunningham", 21, "4219", 3.1);
            Student student6 = new Student("Floyd", "Wansler", 33, "4230", 4.0);

            Teacher teacher1 = new Teacher("Gerett", "Walker", 65, "3001", 3000);
            Teacher teacher2 = new Teacher("Harper", "Cunningham", 51, "3004", 4100);
            Teacher teacher3 = new Teacher("Cross", "William", 54, "3290", 4520);
            Teacher teacher4 = new Teacher("Megan", "William", 58, "3870", 4800);

            List<Student> studentlist = new List<Student>() { student1, student2, student3, student4, student5, student6 };
            List<Teacher> teacherlist = new List<Teacher>() { teacher1, teacher2, teacher3, teacher4 };


            Console.WriteLine($"Hi my name is {student1.Name} , I am {student1.Age} old, I have a GPA of {student1.GPA} and {student1.careerPath()}");

            Console.WriteLine($"Hi my name is {teacher1.Name} , I am {teacher1.Age} old, I have a salary of {teacher1.Salary} and {teacher1.careerPath()}");

            Console.Write("Input 1 to show students or 2 to show teachers: ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    foreach(Student student in studentlist) {
                        student.printStudent();
                    }
                    break;
                case 2:
                    foreach (Teacher teacher in teacherlist) {
                        teacher.printTeacher();
                    }
                    break;
            }


               
            }

        }
    }
