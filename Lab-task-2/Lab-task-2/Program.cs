namespace Lab_task_2
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i <= 3; i++)
            {
                Console.WriteLine("Details for the Car " + i);
                Console.Write("Enter the Engine Number: ");
                var engineNumber = Console.ReadLine(); 

                Console.Write("Enter the acceleration: ");
                var acceleration = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Time: ");
                var time = (float)Convert.ToDouble(Console.ReadLine());

                //CarSpeed carSpeed = new CarSpeed(acceleration,engine_number);
                var carSpeed = new CarSpeed();
                carSpeed._Engine_number= engineNumber ;
                carSpeed._Acceleration =acceleration;


                Console.WriteLine("Engine Number of car set to: " + carSpeed._Engine_number);
                Console.WriteLine("Car's  acceleration is : " + carSpeed._Acceleration);
                if (carSpeed._Engine_number == null) carSpeed.start_car();
                carSpeed.start_car();
                if (carSpeed._start)
                {
                    Console.WriteLine("Velocity of the car after " + time + "seconds is " +
                                      carSpeed.get_velocity(time));
                    carSpeed.get_velocity(time);
                }

                if (carSpeed._start)
                    carSpeed.stop_car();
                else
                    Console.WriteLine("To stop the car ,Car must be in start mode ");
            }
        }
    }
}