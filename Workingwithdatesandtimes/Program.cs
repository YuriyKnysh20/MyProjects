DateTime date1 = new DateTime(2022, 1, 13); // год - месяц - день
Console.WriteLine(date1); // 13.01.2022 0:00:00

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);
Console.WriteLine(DateTime.Today);

DateTime date2 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
Console.WriteLine(date2.AddHours(3)); // 20.07.2015 21:30:25

DateTime date3 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
DateTime date4 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
Console.WriteLine(date3.Subtract(date4)); // 03:00:00
DateTime date = new DateTime(2015, 7, 20, 18, 30, 25);


Console.WriteLine(date.ToLocalTime()); // 20.07.2015 21:30:25
Console.WriteLine(date.ToUniversalTime()); // 20.07.2015 15:30:25
Console.WriteLine(date.ToLongDateString()); // 20 июля 2015 г.
Console.WriteLine(date.ToShortDateString()); // 20.07.2015
Console.WriteLine(date.ToLongTimeString()); // 18:30:25
Console.WriteLine(date.ToShortTimeString()); // 18:30

DateTime now = DateTime.Now;

Console.WriteLine($"D: {now.ToString("D")}");
Console.WriteLine($"d: {now.ToString("d")}");
Console.WriteLine($"F: {now.ToString("F")}");
Console.WriteLine($"f: {now:f}");
Console.WriteLine($"G: {now:G}");
Console.WriteLine($"g: {now:g}");
Console.WriteLine($"M: {now:M}");
Console.WriteLine($"O: {now:O}");
Console.WriteLine($"o: {now:o}");
Console.WriteLine($"R: {now:R}");
Console.WriteLine($"s: {now:s}");
Console.WriteLine($"T: {now:T}");
Console.WriteLine($"t: {now:t}");
Console.WriteLine($"U: {now:U}");
Console.WriteLine($"u: {now:u}");
Console.WriteLine($"Y: {now:Y}");

DateTime now1 = DateTime.Now;
Console.WriteLine(now1.ToString("hh:mm:ss"));
Console.WriteLine(now1.ToString("dd.MM.yyyy"));
