using System;

namespace Basics_U3___C2_Programacion_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());

            int E = B;
            B = C;
            C = A;
            A = D;
            D = E;

            Console.WriteLine("A es {0}, B es {1}, C es {2} y D es {3}", A, B, C, D);
        }
    }
}
