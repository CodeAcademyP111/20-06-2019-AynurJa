using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Every thing will be very good";
            task(str);

        }
        static int task (string str)
        {
            int count = 0;
            char CountEmpty = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == CountEmpty)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
