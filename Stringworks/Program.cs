string text1 = " hello world ";

text1 = text1.Trim(); // результат "hello world"
text1 = text1.Trim(new char[] { 'd', 'h' }); // результат "ello worl"

string text = "Хороший день";
// обрезаем начиная с третьего символа
text = text.Substring(2);
// результат "роший день"
Console.WriteLine(text);
// обрезаем сначала до последних двух символов
text = text.Substring(0, text.Length - 2);
// результат "роший де"
Console.WriteLine(text);


string text2 = "Хороший день";
string substring = "замечательный ";

text2 = text2.Insert(8, substring);
Console.WriteLine(text2);    // Хороший замечательный день

string text3 = "Хороший день";
// индекс последнего символа
int ind = text3.Length - 1;
// вырезаем последний символ
text3 = text3.Remove(ind);
Console.WriteLine(text3);    // Хороший ден

// вырезаем первые два символа
text3 = text3.Remove(0, 2);
Console.WriteLine(text3);    // роший ден

string text4 = "хороший день";

text4 = text4.Replace("хороший", "плохой");
Console.WriteLine(text4);    // плохой день

text4 = text4.Replace("о", "");
Console.WriteLine(text4);    // плхй день

string hello = "Hello world!";

Console.WriteLine(hello.ToLower()); // hello world!
Console.WriteLine(hello.ToUpper()); // HELLO WORLD!