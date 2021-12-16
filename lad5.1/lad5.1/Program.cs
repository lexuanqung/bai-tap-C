using System;

namespace lad5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] vs = new int[n];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("array [{0}]:", i);
                vs[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < 10; j += 2)
            {

                Console.WriteLine("vi tri chan: {0}", j);
            }
        }
    }
}
