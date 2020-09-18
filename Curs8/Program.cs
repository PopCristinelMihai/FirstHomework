using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Curs8
{
    class Program
    {
        public class Person
        {
            public string Name;
            public string Surname;
            public int Age;
            public string Identifier;

            public Person(string name, string surname, int age, string identifier)
            {
                Name = name;
                Surname = surname;
                Age = age;
                Identifier = identifier;
            }
        }

       /* public class Student : Person
        {
            public double GPA;

            public Student( string name, string surname, int age, string identifier, double gpa)
            {
                Name = name;
                Surname = surname;
                Age = age;
                Identifier = identifier;
                GPA = gpa;
            }
        }
    */
       /* public class Teacher : Person
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
        }
       */
        static void Main(string[] args)
        {

            //Student student1 = new Student("Caleb", "Lanter", 22, "4901", 3.8);
            //Student student2 = new Student("Asher", "Hext", 23, "2521", 2.4);
            //Student student3 = new Student("Rae", "Cunningham", 22, "2398", 3.9);
            //Student student4 = new Student("Max", "Denver", 23, "3219", 2.1);
            //Student student5 = new Student("Owen", "Cunningham", 21, "4219", 3.1);
            //Student student6 = new Student("Floyd", "Wansler", 33, "4230", 4.0);

            //Teacher teacher1 = new Teacher("Gerett", "Walker", 65, "3001", 3000);
            //Teacher teacher2 = new Teacher("Harper", "Cunningham", 51, "3004", 4100);
            //Teacher teacher3 = new Teacher("Cross", "William", 54, "3290", 4520);
            //Teacher teacher4 = new Teacher("Megan", "William", 58, "3870", 4800);

            Person person1 = new Person("NAME", "SUERNAME", 30, "31");
            Person person2 = new Person("NAME", "SUERNAME", 30, "31");

            //List<Teacher> teacherlist = new List<Teacher>() { teacher1, teacher2, teacher3, teacher4 };
            //List<Student> studentlist = new List<Student>() { student1, student2, student3, student4, student5, student6};
            List<int> numere = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<Person> personlist = new List<Person>() { person1, person2 };
            using (StreamWriter file = File.CreateText(@"E:/Fisiere CS/file.xml")) {
                XmlSerializer serializer = new XmlSerializer(numere.GetType());
                serializer.Serialize(file, numere);
            }


            }
        }
    }

