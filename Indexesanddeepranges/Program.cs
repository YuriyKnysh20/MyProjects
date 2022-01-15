Index myIndex1 = 2;     // третий элемент
Index myIndex2 = ^2;    // предпоследний элемент

string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
string selected1 = people[myIndex1];    // Sam
string selected2 = people[myIndex2];    // Kate
Console.WriteLine(selected1);
Console.WriteLine(selected2);

Index start = 1;
Index end = 4;
Range myRange1 = start..end;

Range myRange2 = 1..4;

string[] people1 = { "Tom", "Bob", "Sam", "Kate", "Alice" };
string[] peopleRange = people1[1..4]; // получаем 2, 3 и 4-й элементы из массива
foreach (var person1 in peopleRange)
{
    Console.WriteLine(person1);
}