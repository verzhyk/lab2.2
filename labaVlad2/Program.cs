using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaVlad2
{
    class Program
    {
        public static WholeNumber Init(int number)
        {
            return new WholeNumber(number);
        }

        public static void Read()
        {
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out int number);
            WholeNumber number1 = Init(number);

            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out number);
            WholeNumber number2 = Init(number);

            Display(number1 - number2);
            Display(number1 + number2);
        }

        public static void Display(WholeNumber number)
        {
            Console.WriteLine(number);
        }

        static void Main(string[] args)
        {
            Read();
        }
    }
}
