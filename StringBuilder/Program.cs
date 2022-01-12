using System.Text;

var sb = new StringBuilder("Hello World");
Console.WriteLine(sb.ToString());    //  Hello World

StringBuilder sb1 = new StringBuilder("Привет мир");
Console.WriteLine($"Длина: {sb.Length}");       // Длина: 10
Console.WriteLine($"Емкость: {sb.Capacity}");   // Емкость: 16
//Можно сразу задать ёмкость
var sb2 = new StringBuilder("Привет мир", 32);
Console.WriteLine(sb2.ToString());

var sb3 = new StringBuilder("Название: ");
Console.WriteLine(sb3);   // Название: 
Console.WriteLine($"Длина: {sb3.Length}"); // 10
Console.WriteLine($"Емкость: {sb3.Capacity}"); // 16

sb3.Append(" Руководство");
Console.WriteLine(sb3);   // Название: Руководство
Console.WriteLine($"Длина: {sb3.Length}"); // 22
Console.WriteLine($"Емкость: {sb3.Capacity}"); // 32

sb3.Append(" по C#");
Console.WriteLine(sb3);   // Название: Руководство по C#
Console.WriteLine($"Длина: {sb3.Length}"); // 28
Console.WriteLine($"Емкость: {sb3.Capacity}"); // 32

var sb4 = new StringBuilder("Привет мир");
sb4.Append("!");
sb4.Insert(7, "компьютерный ");
Console.WriteLine(sb4);  // Привет компьютерный мир!

// заменяем слово
sb4.Replace("мир", "world");
Console.WriteLine(sb4);  // Привет компьютерный world!

// удаляем 13 символов, начиная с 7-го
sb4.Remove(7, 13);
Console.WriteLine(sb4);  // Привет world!

// получаем строку из объекта StringBuilder
string text = sb4.ToString();
Console.WriteLine(text);    // Привет world!
