using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ЛАБ8_УП
{
    class Program
    {
        private static IEnumerable<double> GetNumbers(string input)
        {
            var matches = Regex.Matches(input, @"-?\d+(?:\.\d+)?", RegexOptions.Compiled);
            return from Match match in matches select double.Parse(match.Value, CultureInfo.InvariantCulture);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите ваше сообщение: ");
            var s = Console.ReadLine();
            var nums = GetNumbers(s);
            if (nums.Any())
                Console.WriteLine("Максимальное число в сообщении: {0}", nums.Max());
            else
                Console.WriteLine("В сообщении нет чисел!");
        }
    }
}
