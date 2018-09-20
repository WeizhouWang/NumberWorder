using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: NumberWorder number\nEg. NumberWorder 1234");
                Console.ReadLine();
                return;
            }
            string result = ConvertNumberToWord(args[0]);
            if (result == null)
            {
                Console.WriteLine("Input contains invalid character\nPlease try again");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(result);
            Console.ReadLine();
            return;
        }

        public static string ConvertNumberToWord(string inputNumber)
        {
            try
            {
                int inputValue = Convert.ToInt32(inputNumber);
                string result = null;
                var digitArray = GetDigits(inputValue);
                foreach(var digit in digitArray.Reverse())
                {
                    result += ((NumberWordEnum)digit).ToString();
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static IEnumerable<int> GetDigits(int source)
        {
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                yield return digit;
            }
        }
    }

    enum NumberWordEnum
    {
        ZERO = 0,
        ONE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
        SIX = 6,
        SEVEN = 7,
        EIGHT = 8,
        NINE = 9
    }
}
