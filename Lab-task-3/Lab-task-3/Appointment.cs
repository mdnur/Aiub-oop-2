namespace Lab_task_3
{
    public class Appointment
    {
        private int members;
        private string NRIC; //readonly string name;
        private double fees;
        private Date visit;
        private Date nextVisit;

        public Appointment(int members, string nRIC, double fees, Date visit, Date nextVisit)
        {
            this.members = members;
            NRIC = nRIC;
            this.fees = fees;
            this.visit = visit;
            this.nextVisit = nextVisit;
        }


        public int Member{
            get { return this.members; }
            set { this.members = value; }
        }

        public string _NRIC => this.NRIC;  //readonly string name;
        public double Fees {
            get { return this.fees; } set { this.fees = value; }
        }

        public Date Visit
        {
            set { this.visit = value; }
            get { return this.visit; }
        }
        public Date NextVisit
        {
            set { this.nextVisit = value; }
            get { return this.nextVisit; }
        }
        public Appointment()
		{
		}

        void displayAppt()
        {

        }
        void displayAppt(string nRIC)
        {
            
        }
    }
}

