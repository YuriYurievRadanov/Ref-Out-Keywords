using System;

namespace Ref_Out
{
    internal class Program
    {
        private static void Main()
        {
            var x = 10;
            var y = 20;

            Change(x, y);

            Console.WriteLine("X = " + x.ToString());
            Console.WriteLine("Y = " + y.ToString());

            Change_Ref(ref x, ref y);

            Console.WriteLine("X = " + x.ToString());
            Console.WriteLine("Y = " + y.ToString());
        }

        private static void Change(int x, int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        private static void Change_Ref(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        int three, five = 0;
        public int GetOutExample(int n, out int sayi)
        {

            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0)
                    three++;

                if (i % 5 == 0)
                    five++;
            }
            sayi = five;

            return three;
        }
    }
}
