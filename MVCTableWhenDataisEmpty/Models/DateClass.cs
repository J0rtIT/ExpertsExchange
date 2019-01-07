using System;

namespace MVCTableWhenDataisEmpty.Models
{
    public class DateClass
    {
        public DateTime EmptyDate { get; set; }
        public DateTime TodayDate { get; set; }

        public DateClass()
        {
            EmptyDate = new DateTime();
            TodayDate = DateTime.Now;
        }

        public bool isItEmpty(DateTime dt)
        {
            DateTime tester = new DateTime(1970, 01, 01, 0, 0, 0, 0);

            if (dt > tester)
            {
                return true;
            }

            return false;
        }
    }
}