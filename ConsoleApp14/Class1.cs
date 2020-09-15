using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class MyCat
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sum(double x, int y)
        {
            return (int)(x + y);
        }
    }

    class Class1
    {
        static void Main()
        {
            MyCat c1 = new MyCat();

            int result = MyCat.Sum(5, 3);
            c1.Sum(2.5, 5);

            Random rnd = new Random();
            rnd.Next();

            int[] arr = new int[3];
            for(int i=0; i<arr.Length; i++)
            {

            }
        }
    }
}
