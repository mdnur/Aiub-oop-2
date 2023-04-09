using System;
namespace Player_Informationv
{
	public class Cricketer:Player
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
}

