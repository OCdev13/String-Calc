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
            Char[] delimeters = {'\n' };
            
            string[] numsArr = nums.Split(delimeters);

            var a = 0;

            foreach (var num in numsArr)
            {
                if (numsArr.Length == 0)
                {
                    return 0;
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
            Console.WriteLine(Add("1\n2\n3\n4\n5"));
            Console.ReadLine();
        }

    }
}


