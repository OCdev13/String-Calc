using System;
using System.Text.RegularExpressions;
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
            // Set a pattern for regex to check for delimiters and push them to an array// 
            var pattern = @"\[(.*?)\]";

            List<string> newDelims = new List<string>
            {
                ",", "\n"
            };

            var matches = Regex.Matches(nums, pattern);

            foreach (Match m in matches)
            {
                newDelims.Add(m.Groups[1].ToString());
            }

            string[] delim = newDelims.ToArray();

            //////////////////////////////////////////////////////////////////////

            //Array for splitting the data//
            string[] numsArr = nums.Split(delim, StringSplitOptions.RemoveEmptyEntries);

            //Array of negative numbers//
            List<string> badNums = new List<string>();


            var a = 0;

            foreach (var num in numsArr)
            {
                if (numsArr.Length == 0)
                {
                    return 0;
                }
                else if (num.Contains('-'))
                {
                    badNums.Add(num);
                }
                else
                {
                    //Parse strings into numbers and check if they are larger than 100
                    //if so, do not use them.//
                    Int32.TryParse(num, out int b);
                    if (b >= 1000)
                    {
                        b = 0;
                    }
                    a = a + b;
                }
            }

            // check for negative numbers and throw error if there are any.//
            if (badNums.Count() != 0)
            {
                var message = "";
                foreach (var b in badNums)
                {
                    message += b + " , ";
                }
                var e = new Exception("negatives not allowed. " + message);
                throw e;
            }
            else
            {
                return a;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add("//[%%%][;;;]\n1%%%2%%%1200;;;14"));
            Console.ReadLine();
        }
    }
}


