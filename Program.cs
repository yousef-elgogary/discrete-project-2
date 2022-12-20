using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_math_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start ;
            int end ;
            int i ;
            int total = 0;
            int flag = 0;
            int j;
            Console.WriteLine("Enter The First Number");
            start=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Last Number");
            end=int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect numbers between "+start+" and "+end);
            for (j = start; j <= end; j++)
            {
                for (i = 1; i < j; i++)
                {
                    if (j % i == 0)
                        total += i;
                }
                if ((total == j) && (j != 0))
                {
                    flag = 1;
                    Console.WriteLine(j );
                }
                total = 0;
            }
            if (flag == 0)
                Console.WriteLine("There in no perfect number between the given range");
            Console.ReadKey();
        }
    }
    
}
