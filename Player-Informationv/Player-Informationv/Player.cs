using System;
namespace Player_Informationv
{
	public abstract class Player
	{
        private string id;
        private string name;
        private double salary;
        private DateTime joiningDate;

        public Player(string id, string name, double salary, DateTime joiningDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine("ID: {0}", this.id);
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Salary: {0}", this.salary);
            Console.WriteLine("Joining Date: {0}", this.joiningDate.ToString("dd-MM-yyyy"));
        }
    }
}

