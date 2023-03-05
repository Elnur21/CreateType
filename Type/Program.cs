using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            Student studentClone= new Student();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Telebe ucun melumatlari doldurun.");
                Console.Write("Adi daxil edin: ");
                studentClone.name = Console.ReadLine();
                Console.Write("Soyadi daxil edin: ");
                studentClone.sureName = Console.ReadLine();
            l1:
                Console.Write("Yasi daxil edin: ");
                if (!int.TryParse(Console.ReadLine(), out studentClone.age)) goto l1;
                Console.Write("Ixtisasi daxil edin: ");
                studentClone.speciality = Console.ReadLine();
                Console.Write("Qrupun nomresini daxil edin: ");
                studentClone.groupNo = Console.ReadLine();
                students[i] = studentClone;
                helper(i, students.Length);
            }

            for (int i = 0; i < students.Length; i++)
            {
                studentClone = students[i];
                Console.WriteLine($"{i + 1}.Telebe:");
                Console.Write($"Adi: {studentClone.name}");
                Console.Write($"Soyadi: {studentClone.sureName}");
                Console.Write($"Yasi: {studentClone.age}");
                Console.Write($"Ixtisasi: {studentClone.speciality}");
                Console.Write($"Qrupun nomresi: {studentClone.groupNo}");
                Console.WriteLine(" ");
                helper(i,students.Length);
            }

        }
        static void helper(int i, int length)
        {
            if (i != (length - 1))
            {
                Console.WriteLine("");
                Console.WriteLine("=================================");
                Console.WriteLine("");
            }
        }
    }
}
