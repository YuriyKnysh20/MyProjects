using System.Text.RegularExpressions;

string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
Regex regex = new Regex(@"туп(\w*)");
MatchCollection matches = regex.Matches(s);
if (matches.Count > 0)
{
    foreach (Match match in matches)
        Console.WriteLine(match.Value);
}
else
{
    Console.WriteLine("Совпадений не найдено");
}

Regex regex1 = new Regex(@"туп(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
Console.WriteLine(regex1);

string s1 = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
Regex regex2 = new Regex(@"\w*губ\w*");
Console.WriteLine(regex2);
//Нахождение телефонного номера
string s2 = "456-435-2318";
Regex regex3 = new Regex(@"\d{3}-\d{3}-\d{4}");
Console.WriteLine( regex3);

Regex regex4 = new Regex(@"[2\|3]{3}\.[0-9]{3}\.\d{4}");
// этому выражению будет соответствовать строка "222.222.2222"
Console.WriteLine(regex4);

string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
var data = new string[]
{
    "tom@gmail.com",
    "+12345678999",
    "bob@yahoo.com",
    "+13435465566",
    "sam@yandex.ru",
    "+43743989393"
};

Console.WriteLine("Email List");
for (int i = 0; i < data.Length; i++)
{
    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
    {
        Console.WriteLine(data[i]);
    }
}

string text = "Мама  мыла  раму. ";
string pattern1 = @"\s+";
string target = " ";
Regex regex5 = new Regex(pattern1);
string result = regex5.Replace(text, target);
Console.WriteLine(result);
