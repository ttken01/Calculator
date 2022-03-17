using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Radix
    {
        private int number;
        public Radix(int number)
        {
            if (number < 0)
                throw new ArgumentException("Incorrect Value");
            this.number = number;
        }
        public string ConvertDecimalToAnother(int radix = 2)
        {
            int n = this.number;
            if (radix < 2 || radix > 16)
                throw new ArgumentException("Invalid Radix");
            List<string> result = new List<string>();
            while (n > 0)
            {
                int value = n % radix;
                if (value < 10)
                    result.Add(value.ToString());
                else
                {
                    switch (value)
                    {
                        case 10: result.Add("A"); break;
                        case 11: result.Add("B"); break;
                        case 12: result.Add("C"); break;
                        case 13: result.Add("D"); break;
                        case 14: result.Add("E"); break;
                        case 15: result.Add("F"); break;
                    }
                }
                n /= radix;
            }
            result.Reverse();
            return String.Join("", result.ToArray());
        }
    }
}
