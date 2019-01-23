using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_class_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;

            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();
        }
    }
}
