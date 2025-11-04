using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Console_Application
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string   Surname { get; set; }
        public int[] Grades { get; set; }


        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Grades = new int[0];
            
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Ad: {Name}, Soyad: {Surname}, Orta qiymət: {GetAverage():F2}");
        }
        public double GetAverage()
        {
            if(Grades.Length == 0) return 0;

            int sum = 0;
            foreach(var g in Grades)
            {
                sum += g;
            }
            return sum/ Grades.Length;
        }
    }
}
