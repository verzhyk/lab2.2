using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaVlad2
{
    public class WholeNumber
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public WholeNumber()
        {
            Number = 0;
        }

        public WholeNumber(int number)
        {
            Number = number;
        }

        public WholeNumber(WholeNumber number)
        {
            Number = number.Number;
        }

        public static WholeNumber operator +(WholeNumber number1, WholeNumber number2)
        {
            return new WholeNumber(number1.Number + number2.Number);
        }

        public static WholeNumber operator -(WholeNumber number1, WholeNumber number2)
        {
            return new WholeNumber(number1.Number - number2.Number);
        }

        public static implicit operator string(WholeNumber wholeNumber) => wholeNumber.ToString();

        public override string ToString() => $"{Number}";

    }
}
