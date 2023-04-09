using System;
namespace Player_Informationv
{
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

