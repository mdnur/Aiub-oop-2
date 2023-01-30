using System;
namespace CalculatorApp
{
    public class Calculator
    {
        private int number1;
        private int number2;

        public Calculator()
        {

        }
        public void setNumber1(int number1)
        {
            this.number1 = number1;
        }
        public int getNumber1()
        {
            return this.number1;
        }

        public void setNumber2(int number2)
        {
            this.number2 = number2;
        }
        public int getNumber2()
        {
            return this.number2;
        }

        //public int sum(int number1, int number2)
        public int sum()
        {
            return this.number1 + number2;
        }

        //public int sub(int number1, int number2)
             public int sub()
        {
            return this.number1 - number2;
        }

        //public int mal(int number1, int number2)
            public int mal()
        {
            return this.number1 * number2;
        }
        //public int div(int number1, int number2)
        public int div()
        {
            return this.number1 / number2;
        }
        public int sqaure()
        {
            return (int)Math.Pow(number1,number2);
        }
        public double remainder()
        {
            return number1 % number2;
        }

        public double percent(int number1)
        {
            return number1 / 100;
        }
        public int max()
        {
            return Math.Max(this.number1, this.number2);
        }
        public int min()
        {
            return Math.Min(this.number1, this.number2);
        }
    }
}
