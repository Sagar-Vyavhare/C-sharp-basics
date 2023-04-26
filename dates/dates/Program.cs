using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dates
{
    internal class Program
    {
        void findDifferenceBetDate()
        {
            Console.WriteLine("enter date");
            DateTime d = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter second date");
            DateTime scndDate= Convert.ToDateTime(Console.ReadLine());
            TimeSpan diff=scndDate.Subtract(d);
            Console.WriteLine("total differce is:"+diff.Days+" Days "+diff.Hours+" hours "+diff.Minutes+" minutes ");
        }
        void contTime()
        {
            Console.WriteLine("enter date");
            DateTime d = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter second date");
            DateTime scndDate = Convert.ToDateTime(Console.ReadLine());
            TimeSpan diff = scndDate.Subtract(d);
            Console.WriteLine(diff.Hours + " hours " + diff.Minutes + " minutes "+diff.Seconds+" seconds");
        }

        void getTotalAmoount()
        {
            Console.Write("Enter Start Time:");
            DateTime start_time = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter end Time:");
            DateTime end_time = Convert.ToDateTime(Console.ReadLine());
            TimeSpan diff= (end_time.Subtract(start_time));
            int total_minuts = Convert.ToInt32(diff.TotalMinutes);
            Console.Write("Enter Rest Time:");
            int rest_time = Convert.ToInt32(Console.ReadLine());
            int total_duration = total_minuts - rest_time;
            Console.Write("Enter Rate per hour:");
            Double rate_per_hour = Convert.ToDouble(Console.ReadLine());
            Double rate_per_minit=rate_per_hour/60;
            Console.WriteLine("total ammount is:"+total_duration*rate_per_minit);

        }

        void getage()
        {
            Console.Write("Enter birth date :");
            DateTime birth_date = Convert.ToDateTime(Console.ReadLine());

            DateTime date_now = DateTime.Now;
            TimeSpan diff = (date_now.Subtract(birth_date));
            Console.WriteLine(diff.TotalSeconds);
        }
        static void Main(string[] args)
        {
            //DateTime d = DateTime.Now;

            //Console.WriteLine(d.ToString());
            //Console.WriteLine(d.ToShortDateString());

            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.Minute);
            //Console.WriteLine(d.Second);
            //Console.WriteLine(d.Hour);
            //Console.WriteLine(d.Month);
            //Console.WriteLine(d.Year);
            //Console.WriteLine(d.Day);
            //Console.WriteLine(d.DayOfWeek);
            //Console.WriteLine(d.DayOfYear);

            Program p = new Program();
            //p.findDifferenceBetDate();
            //p.contTime();
           // p.getTotalAmoount();
           p.getage();

            Console.ReadLine();
        }
    }
}