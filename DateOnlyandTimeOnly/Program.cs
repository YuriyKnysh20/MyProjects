
using System.Globalization;

DateOnly julianDate = new DateOnly(2022, 1, 6, new JulianCalendar());
Console.WriteLine(julianDate); // 19.01.2022
//DateOnly();
///DateOnly(int year, int month, int day);
//DateOnly(int year, int month, int day);
//DateOnly(int year, int month, int day, System.Globalization.Calendar calendar);

DateOnly now = new DateOnly(2022, 1, 6);
Console.WriteLine(now.Day);         // 6
Console.WriteLine(now.DayNumber);   // 738160
Console.WriteLine(now.DayOfWeek);   // Thursday
Console.WriteLine(now.DayOfYear);   // 6
Console.WriteLine(now.Month);       // 1
Console.WriteLine(now.Year);        // 2022

DateOnly now1 = DateOnly.Parse("06.01.2022");
Console.WriteLine(now1); // 06.01.2022
now1 = now1.AddDays(1);   // 07.01.2022
now1 = now1.AddMonths(4); // 07.04.2022
now1 = now1.AddYears(-1); // 07.05.2021
Console.WriteLine(now1.ToShortDateString());  // 07.05.2021
Console.WriteLine(now1.ToLongDateString());   // 7 мая 2021 г.

TimeOnly time1 = new TimeOnly(4, 30);
Console.WriteLine(time1);   // 4: 30

TimeOnly time2 = new TimeOnly(14, 23, 30);
Console.WriteLine(time2);   // 14: 23

TimeOnly time = new TimeOnly(14, 23, 30);
Console.WriteLine(time.Hour);       // 14
Console.WriteLine(time.Minute);     // 23
Console.WriteLine(time.Second);     // 30

TimeOnly time3 = TimeOnly.Parse("06:33:22");
Console.WriteLine(time);        // 6:33
time3 = time3.AddHours(1);        // 7:33
time3 = time3.AddMinutes(-23);   // 7:10

Console.WriteLine(time3.ToShortTimeString());  // 7:10
Console.WriteLine(time3.ToLongTimeString());   // 7:10:22