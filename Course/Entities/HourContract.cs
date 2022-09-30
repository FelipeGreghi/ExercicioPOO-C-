using System;


namespace Course.Entities
{
    internal class HourContract
    {
        //Auto Properties
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        //Contructors
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Methods
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
