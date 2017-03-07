using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqPractice
{
    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student1> GetAllStudent1()
        {
            List<Student1> listStudent1 = new List<Student1>();

            Student1 Student11 = new Student1
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listStudent1.Add(Student11);

            Student1 Student12 = new Student1
            {
                ID = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listStudent1.Add(Student12);

            Student1 Student13 = new Student1
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            listStudent1.Add(Student13);

            Student1 Student14 = new Student1
            {
                ID = 104,
                Name = "Steve",
                Gender = "Male"
            };
            listStudent1.Add(Student14);

            Student1 Student15 = new Student1
            {
                ID = 105,
                Name = "Pam",
                Gender = "Female"
            };
            listStudent1.Add(Student15);

            return listStudent1;
        }
    }
    }