using System;

namespace CalculatorApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Which Operation do you want to ");
            Console.WriteLine("1.Sum");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.mal");
            Console.WriteLine("4.div");
            Console.WriteLine("5.Remainder");
            Console.WriteLine("q6.To The power");
            Console.WriteLine("7.Percentage");
            Console.WriteLine("8.Min");
            Console.WriteLine("9.Max");
            Console.WriteLine("10.Exit");

            Console.Write("Enter choice: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            //Calculator cal;
            Calculator cal = new Calculator();
            cal.setNumber1(number1);
            cal.setNumber2(number2);

            //bool s = true;
            //while (true)
            //{
            switch (choose)
            {
                case 1:
                    int sum = cal.sum();
                    Console.WriteLine(cal.sum());
                    break;
                case 2:
                    Console.WriteLine(cal.sub());
                    break;
                case 3:
                    Console.WriteLine(cal.mal());
                    break;
                case 4:
                    Console.WriteLine(cal.div());
                    break;
                case 5:
                    Console.WriteLine(cal.remainder());
                    break;
                case 6:
                    Console.WriteLine(cal.sqaure());
                    break;
                case 7:
                    Console.WriteLine(cal.percent(number1));
                    break;
                case 8:
                    Console.WriteLine(cal.min());
                    break;
                case 9:
                    Console.WriteLine(cal.max());
                    break;
                //case 10:
                //    s = false;
                //    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

            //}
        }
    }
}