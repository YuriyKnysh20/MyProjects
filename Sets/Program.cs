
string[] softs = { "Microsoft", "Google", "Apple" };
string[] hards = { "Apple", "IBM", "Samsung" };

// разность последовательностей
var results = softs.Except(hards);

foreach (string s3 in results)
    Console.WriteLine(s3);

string[] soft = { "Microsoft", "Google", "Apple" };
string[] hard = { "Apple", "IBM", "Samsung" };

// пересечение последовательностей
var result = soft.Intersect(hard);

foreach (string s in result)
    Console.WriteLine(s);

string[] soft1 = { "Microsoft", "Google", "Apple" };
string[] hard1 = { "Apple", "IBM", "Samsung" };

// объединение последовательностей
var result1 = soft1.Union(hard1);

foreach (string s1 in result1)
    Console.WriteLine(s1);