using System;

namespace oop
{
      public class Student
    {
        private int _no { get; set; }
        public int No
        {
            get => _no;
            set => _no = value;
        }
        private int _id { get; set; }
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        private string _name { get; set; }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private float _grade { get; set; }
        public float Grade
        {
            get => _grade;
            set => _grade = value;
        }
        public Student() { }
        public Student(int no, int id, string name, float grade)
        {
            _no = no;
            _id = id;
            _name = name;
            _grade = grade;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1,11,"ali",24);
            s1.Name = "Husein";
            String s;
            Console.WriteLine(s1.No+" "+s1.Name);
            String s = "name1";
            String s2 = "name2";
            String r = $"{s}-{s2}";
            Console.WriteLine(r);
        }
    }
  

}
