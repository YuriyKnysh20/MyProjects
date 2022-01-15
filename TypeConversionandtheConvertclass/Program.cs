
using System.Globalization;

IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
double number = double.Parse("23.56", formatter);
Console.WriteLine(number);   // 23,56

int a = int.Parse("10");
double b = double.Parse("23,56");
decimal c = decimal.Parse("12,45");
byte d = byte.Parse("4");
Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");

Console.WriteLine("Введите строку:");
string? input = Console.ReadLine();

bool result = int.TryParse(input, out var number1);
if (result == true)
    Console.WriteLine($"Преобразование прошло успешно. Число: {number1}");
else
    Console.WriteLine("Преобразование завершилось неудачно");

int n = Convert.ToInt32("23");
bool b1 = true;
double d1 = Convert.ToDouble(b1);
Console.WriteLine($"n={n}  d={d1}");