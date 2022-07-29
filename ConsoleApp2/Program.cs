using System.Collections.Generic;

namespace IncrementApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*000002-> 000003
999999-> 000000
GL - 321->GL - 322
GL - 999->GL - 000
DRI000EDERS0RE->DRI000EDERS0RE
DRI000EDERS0RE99999->DRI000EDERS0RE00000*/

            var inc = "000002";
            Console.WriteLine(inc + "->" + Increment(inc.ToCharArray()));

            inc = "999999";
            Console.WriteLine(inc + "->" + Increment(inc.ToCharArray()));

            inc = "GL - 321";
            Console.WriteLine(inc + "->" + Increment(inc.ToCharArray()));

            inc = "GL - 999";
            Console.WriteLine(inc + "->" + Increment(inc.ToCharArray()));

            inc = "DRI00EDER0RE";
            Console.WriteLine(inc + "->" + Increment(inc.ToCharArray()));

            inc = "DRI000DER0RE99999";
            Console.WriteLine(inc + "->" + Increment(inc.ToCharArray()));
        }

        public static string Increment(char[] referenceNumber)
        {
            var reverseList = referenceNumber.Reverse().ToList();
            var result = string.Empty;
            var needContinue = true;
            for (int i = 0; i < reverseList.Count(); i++)
            {
                var currentChar = reverseList[i];
                if (char.IsNumber(currentChar) && needContinue)
                {
                    var num = int.Parse(currentChar.ToString());
                    if (num == 9)
                    {
                        result += "0";
                    }
                    else
                    {
                        result += num + 1;
                        needContinue = false;
                    }
                }
                else
                {
                    var asd = new List<char>(reverseList);
                    asd.RemoveRange(0, i);
                    var end = new string(asd.ToArray());
                    result += end;
                    break;
                }
            }

            return new string(result.Reverse().ToArray());

        }
    }
}