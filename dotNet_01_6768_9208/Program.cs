using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_8768_9208
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Random r = new Random();//DateTime.Now.Millisecond);
            a = r.Next();
            int b = r.Next();
            int[] A = new int[20];
            int[] B = new int[20];
            int[] C = new int[20];

            for (int i = 0; i < 20; i++)
            {
                A[i] = r.Next(12, 129);
                B[i] = r.Next(12, 129);
                int efresh = A[i] - B[i];
                if (efresh < 0) efresh *= -1;
                C[i] = efresh;

            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,-3} ", A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,-3} ", B[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,-3} ", C[i]);
            }


            Console.ReadKey();
        }
    }
}


