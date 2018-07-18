using System;

namespace SumOfTwoInArrayEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Enter the size of integer array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for k");
            int k;
            k = Convert.ToInt32(Console.ReadLine());
            int[] abc = new int[n];
            Console.WriteLine("Enter the values in integer array");
            for (int i = 0; i < n; i++)
            {
                abc[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program p = new Program();
            Console.WriteLine(Convert.ToString(p.MyMethod(abc, k)));
            Console.ReadLine();
        }

        public bool MyMethod(int[] xyz,int k)
        {
            Array.Sort(xyz);
            int index = -1;
            for (int x = 0; x < xyz.Length; x++)
            {
                index = Array.BinarySearch(xyz, k - xyz[x]);
                if (0 < index)
                    return true;
            }

            return false;
        }
    }
}
