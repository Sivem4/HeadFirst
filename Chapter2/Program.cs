using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////
            //string result = "";
            //int x = 3;
            //while (x > 0)
            //{
            //    if(x > 2)
            //    {
            //        result = result + "a";
            //    }

            //    x = x - 1;
            //    result = result + "-";

            //    if (x == 2)
            //    {
            //        result = result + "b c";
            //    }
            //    if(x == 1)
            //    {
            //        result = result + "d";
            //        x = x - 1;
            //    }
            //}
            //Console.WriteLine(result);
            //Console.ReadKey();
            /////////////////////////////////////////////////////////////////////////////////////////////////
            int x = 0;
            string poem = "";

            while (x < 4)
            {
                poem = poem + "a";
                if (x < 1)
                {
                    poem = poem + " ";
                }
                poem = poem + "n";

                if (x < 1)
                {
                    poem = poem + "oise ";
                    x = x - 1;
                }

                if (x == 1)
                {
                    poem = poem + "noys ";
                }

                if (x > 1)
                {
                    poem = poem + " oyster";
                }
                x = x + 2;
            }
            Console.WriteLine(poem);
            Console.ReadKey();
        }
    }
}
