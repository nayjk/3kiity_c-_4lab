using System;
namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student anton = new Student("Антон", "1пп", new int[] { 2, 2, 5, 4, 5 });
            Student artem = new Student("Артём", "1пп", new int[] { 3, 2, 3, 4, 5 });
            Student sasha = new Student("Саша", "1пп", new int[] { 1, 3, 2, 4, 5 });
            Student masha = new Student("Маша", "1пп", new int[] { 5, 2, 3, 4, 5 });
            Student dasha = new Student("Даша", "1пп", new int[] { 1, 2, 4, 5, 5 });
            Student vika = new Student("Вика", "1пп", new int[] { 2, 2, 3, 4, 5 });

            Student[] students = new Student[] { anton, artem, sasha, masha, dasha, vika };

            Array.Sort(students, (a,b) => a.marks.Average().CompareTo(b.marks.Average()));

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.name} - {student.marks.Average()}");
            }
        }
    }
    struct Student
    {
        public string name;
        public string groub;
        public int[] marks;

        public Student(string name, string groub, int[] marks)
        {
            this.name = name;
            this.groub = groub;
            this.marks = marks;
        }
    }
}
