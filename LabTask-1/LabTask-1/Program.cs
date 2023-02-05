using System;

namespace LabTask1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the Engine Number: ");
                string engine_number = Console.ReadLine();

                Console.Write("Enter the acceleration: ");
                float acceleration = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Time: ");
                float time = (float)Convert.ToDouble(Console.ReadLine());

                CarSpeed carSpeed = new CarSpeed(acceleration,engine_number);
               
               
               


                Console.WriteLine("Engine Number of car set to: " + carSpeed.get_engine_number());
                Console.WriteLine("Car's  acceleration is : " + carSpeed.get_engine_number());
                carSpeed.start_car();
                Console.WriteLine("Velocity of the car after " +time +"seconds is "+ carSpeed.get_velocity(time));
                carSpeed.get_velocity(time);
                carSpeed.stop_car();

            }
        }
    }
}
