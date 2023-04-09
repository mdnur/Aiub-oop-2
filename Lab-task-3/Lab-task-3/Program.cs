using System;
namespace Lab_task_3
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

    public class Footballer : Player
    {
        private int totalGoal;
        private int totalAssist;

        public Footballer(string id, string name, double salary, DateTime joiningDate, int totalGoal, int totalAssist)
            : base(id, name, salary, joiningDate)
        {
            this.totalGoal = totalGoal;
            this.totalAssist = totalAssist;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Goal: {0}", this.totalGoal);
            Console.WriteLine("Total Assist: {0}", this.totalAssist);
        }
    }
    public class Cricketer : Player
    {
        private int totalRun;
        private int totalWicket;

        public Cricketer(string id, string name, double salary, DateTime joiningDate, int totalRun, int totalWicket)
            : base(id, name, salary, joiningDate)
        {
            this.totalRun = totalRun;
            this.totalWicket = totalWicket;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Run: {0}", this.totalRun);
            Console.WriteLine("Total Wicket: {0}", this.totalWicket);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cr = new Cricketer("P-01", "Shakib", 70000, new DateTime(2006, 8, 6), 6755, 285);
            Footballer ft = new Footballer("P-02", "Jamal", 50000, new DateTime(2013, 6, 13), 20, 15);
            cr.ShowInfo();
            ft.ShowInfo();
        }
    }
}

