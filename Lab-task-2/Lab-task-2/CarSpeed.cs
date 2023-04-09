using System;

namespace Lab_task_2
{
    public class CarSpeed
    {
        private float acceleration;
        private string engine_number;
        private bool start;

        // using accessors to get and 
        // set the value of studentName
        public float _Acceleration
        {
            get{
                return this.acceleration;
            }
            
            set
            {
                this.acceleration = value;
            }
        }
        public string _Engine_number
        {
            get{
                return this.engine_number;
            }
            set
            {
                this.engine_number = value;
            }
        }
        
        public bool _start
        {
            get{
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }
        
        

        public CarSpeed(float acceleration = 0, string engine_number = null, bool start = false)
        {
            this.acceleration = acceleration;
            this.engine_number = engine_number;
            this.start = start;
        }

        public void start_car()
        {
            start = true;
            if (start) Console.WriteLine("Car started successfully”.");
        }

        public bool get_start()
        {
            return start;
        }

        public void stop_car()
        {
            if (!start) return;

            start = false;
            if (!start) Console.WriteLine("Car stopped successfully”.");
        }

        
       
        public float get_velocity(float time)
        {
            if (start == false) return 0;

            return acceleration * time;
        }
    }
}