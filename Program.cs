using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            
            float mass = 65;
            float lenght = 1.89f;
            float bmi;
            bmi = mass / (lenght * lenght);
            Console.WriteLine("1st:\n\nMy BMI is "+bmi+"\n\n");

            // 2

            float age = 17;
            float gr = 22;
            float a, b, grad;
            a = 100 % gr;
            b = age - (a / gr);
            grad = 10 * gr;
            double l = (4 * (3.14 * a * b + (a - b) * (a - b))/(a + b)) * (grad/360);
            Console.WriteLine("2nd:\n\nThe curve lenght is " + l);

            // 3

            double S = 12511;
            double a0 = 22;
            Console.WriteLine("\n\n3rd:\n\nType the N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double d = (2*S-2*a0*n)/(n*(n-1));
            double N = a0 + d * (n - 1);
            Console.WriteLine("\n\nThe step is " + d + ", and the " + n + "th term is " + N);


            Console.WriteLine("\n\npress any key to continue");
            Console.ReadKey();
        }
    }
}
