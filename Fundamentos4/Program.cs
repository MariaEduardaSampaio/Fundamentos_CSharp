// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime();
            Console.WriteLine(data.AddDays(43));
            Console.WriteLine(data.AddMonths(18));
            Console.WriteLine(data.AddHours(26));

            /* 
            var hoje = DateTime.Now;
            Console.WriteLine("agora: " + hoje);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(hoje.DayOfWeek);
            Console.WriteLine(hoje.DayOfYear);

            var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss}", hoje);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:D}", hoje);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:r}", hoje); // r, s ou u
            Console.WriteLine(formatada);

            DateTime? data2 = null;
            Console.WriteLine(data2);
            WorkingWithDates();
            Timezone();
            */
            DateFunctions();

        }

        static void WorkingWithDates()
        {
            Console.Clear();
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", en));
        }

        static void DateFunctions()
        {
            Console.Clear();
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine("Dia da semana: " + isWeekDay(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool isWeekDay(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
        static void Timezone()
        {
            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia =
                TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("-----------------");
            }
        }
    }
}