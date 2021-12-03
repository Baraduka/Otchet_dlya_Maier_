using System;

namespace Лаб.раб._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, r; int i;
            Console.WriteLine("Введите s:");
            s = Convert.ToString(Console.ReadLine());
            string[] A = s.Split(' ');
            for (i = 0; i < A.Length; i++)
                if (A[i].EndsWith("я"))
                    A[i] = A[i] = A[i].Remove(0, 3);
            r = string.Join(" ", A);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
