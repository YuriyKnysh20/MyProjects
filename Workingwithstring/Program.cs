string s1 = "hello";
string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

Console.WriteLine(s1);  // hello
Console.WriteLine(s2);  // aaaaaaa
Console.WriteLine(s3);  // world
Console.WriteLine(s4);  // orl

string message = "hello";
// получаем символ
char firstChar = message[1]; // символ 'e'
Console.WriteLine(firstChar);   //e

Console.WriteLine(message.Length);  // длина строки  
//Перебор строки
string message1 = "Goodbye";

for (var i = 0; i < message.Length; i++)
{
    Console.WriteLine(message[i]);
}
foreach (var ch in message)
{
    Console.WriteLine(ch);
}

string message2 = "hello";
string message3 = "hello";

Console.WriteLine(message2 == message3);    // true


string t1 = "hello";
string t2 = "world";
string t3 = t1 + " " + t2; // результат: строка "hello world"
string t4 = string.Concat(t3, "!!!"); // результат: строка "hello world!!!"

Console.WriteLine(t4);


string s5 = "apple";
string s6 = "a day";
string s7 = "keeps";
string s8 = "a doctor";
string s9 = "away";
string[] values = new string[] { s5, s6, s7, s8, s9 };

string s10 = string.Join(" ", values);
Console.WriteLine(s10); // apple a day keeps a doctor away


string u1 = "hello";
string u2 = "world";

int result = string.Compare(u1, u2);
if (result < 0)
{
    Console.WriteLine("Строка u1 перед строкой u2");
}
else if (result > 0)
{
    Console.WriteLine("Строка u1 стоит после строки u2");
}
else
{
    Console.WriteLine("Строки u1 и u2 идентичны");
}
// результатом будет "Строка u1 перед строкой u2"

string q1 = "hello world";
char ch1 = 'o';
int indexOfChar = q1.IndexOf(ch1); // равно 4
Console.WriteLine(indexOfChar);

string substring = "wor";
int indexOfSubstring = q1.IndexOf(substring); // равно 6
Console.WriteLine(indexOfSubstring);


var files = new string[]
{
    "myapp.exe",
    "forest.jpg",
    "main.exe",
    "book.pdf",
    "river.png"
};

for (int i = 0; i < files.Length; i++)
{
    if (files[i].EndsWith(".exe"))
        Console.WriteLine(files[i]);
}

string text = "И поэтому все так произошло";

string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


foreach (string s in words)
{
    Console.WriteLine(s);
}

