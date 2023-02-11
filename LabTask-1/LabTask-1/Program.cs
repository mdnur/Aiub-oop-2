using System;

namespace LabTask1
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i <= 3; i++)
            {
                Console.WriteLine("Details for the Car " + i);
                Console.Write("Enter the Engine Number: ");
                var engine_number = Console.ReadLine();

                Console.Write("Enter the acceleration: ");
                var acceleration = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Time: ");
                var time = (float)Convert.ToDouble(Console.ReadLine());

                //CarSpeed carSpeed = new CarSpeed(acceleration,engine_number);
                var carSpeed = new CarSpeed();
                carSpeed.set_engine_number(engine_number);
                carSpeed.set_acceleration(acceleration);


                Console.WriteLine("Engine Number of car set to: " + carSpeed.get_engine_number());
                Console.WriteLine("Car's  acceleration is : " + carSpeed.get_acceleration());
                if (carSpeed.get_engine_number() == null) carSpeed.start_car();
                carSpeed.start_car();
                if (carSpeed.get_start())
                {
                    Console.WriteLine("Velocity of the car after " + time + "seconds is " +
                                      carSpeed.get_velocity(time));
                    carSpeed.get_velocity(time);
                }

                if (carSpeed.get_start())
                    carSpeed.stop_car();
                else
                    Console.WriteLine("To stop the car ,Car must be in start mode ");
            }
        }
    }
}