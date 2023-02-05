using System;
namespace LabTask1
{
    public class CarSpeed
    {
        private float acceleration;
        private string engine_number;
        private bool start;

        public CarSpeed(float acceleration = 0, string engine_number = "", bool start = false)
        {
            this.acceleration = acceleration;
            this.engine_number = engine_number;
            this.start = start;
        }

        public void start_car()
        {
            this.start = true;
            if (this.start)
            {
                Console.WriteLine("Car started successfully”.");
            }
        }
        public void stop_car()
        {
            this.start = false;
            if (!this.start)
            {
                Console.WriteLine("Car stopped successfully”.");
            }
        }
        public void set_acceleration(float acceleration)
        {
            this.acceleration = acceleration;
        }
        public void set_engine_number(string engine_number)
        {
            this.engine_number = engine_number;
        }

        public float get_acceleration()
        {
            return this.acceleration;
        }

        public string get_engine_number()
        {
            return this.engine_number;
        }

        public float get_velocity(float time)
            {
            if(this.start == false)
            {
                return 0;
            }
            return this.acceleration*time;
        }
    }
}
