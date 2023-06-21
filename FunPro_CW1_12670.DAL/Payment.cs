using System;

namespace FunPro_CW1_12670.DAL
{
    public class Payment
    {
        public static DateTime date;
        public static int region;
        public static int headcount;
        public static int limit;
        public static int paid;

        public int Id { get; set; }

        public DateTime Date { get; set; }
        
        public int Region { get; set; }
     
        public int Headcount { get; set; }

        public int Limit { get; set; }

        public decimal Paid { get; set; }

        public Payment()
        {
        }

        public Payment(DateTime date, int region, int headcount, int limit, decimal paid)
        {
            Date = date;
            Region = region;
            Headcount = headcount;
            Limit = limit;
            Paid = paid;
        }
    }
}
