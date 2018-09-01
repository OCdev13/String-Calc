using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        private static int Add(string nums)
        {
            
            string[] numsArr = nums.Split(',');

            var a = 0;

            foreach (var num in numsArr)
            {
                if (numsArr.Length == 0)
                {
                    return 0;
                }
                else if (numsArr.Length > 3)
                {
                    throw new ArgumentException("There are more than 3 numbers in this string.", "numsArr");
                }
                else
                {
                    Int32.TryParse(num, out int b);
                    a = a + b; 
                }
            }
            return a; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add("1,2,3,4,5,6,7,8"));
            Console.ReadLine();
        }

    }
}


