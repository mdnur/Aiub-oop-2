using System;
namespace Lab_task_3
{
	public class Date
	{
		private int dd;
        private int mm;
        private int yy;

        public Date()
		{

		}

        public Date(int dd= 1, int mm=1 , int yy=2017)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }

        public int Dd
        {
            set;get;
        }
        public int Mm
        {
            set;get;
        }
        public int Yy
        {
            set;get;
        }

    }
}

