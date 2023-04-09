using System;
namespace Player_Informationv
{
	public class Footballer :Player
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
}

