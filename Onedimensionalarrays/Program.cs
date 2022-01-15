var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

// находим индекс элемента "Bob"
int bobIndex = Array.BinarySearch(people, "Bob");
// находим индекс первого элемента "Tom"
int tomFirstIndex = Array.IndexOf(people, "Tom");
// находим индекс последнего элемента "Tom"
int tomLastIndex = Array.LastIndexOf(people, "Tom");
// находим индекс первого элемента, у которого длина строки больше 3
int lengthFirstIndex = Array.FindIndex(people, person => person.Length > 3);
// находим индекс последнего элемента, у которого длина строки больше 3
int lengthLastIndex = Array.FindLastIndex(people, person => person.Length > 3);

Console.WriteLine($"bobIndex: {bobIndex}");                 // 2
Console.WriteLine($"tomFirstIndex: {tomFirstIndex}");       // 0
Console.WriteLine($"tomLastIndex: {tomLastIndex}");         // 4
Console.WriteLine($"lengthFirstIndex: {lengthFirstIndex}"); // 3
Console.WriteLine($"lengthLastIndex: {lengthLastIndex}");   // 5

var people1 = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

// находим первый и последний элементы
// где длина строки больше 3 символов
string? first = Array.Find(people1, person => person.Length > 3);
Console.WriteLine(first); // Kate
string? last = Array.FindLast(people1, person => person.Length > 3);
Console.WriteLine(last); // Alice

// находим элементы, у которых длина строки равна 3
string[] group = Array.FindAll(people1, person => person.Length == 3);
foreach (var person in group) Console.WriteLine(person);
// Tom Sam Bob Tom

var people2 = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

Array.Reverse(people2);

foreach (var person in people2)
    Console.WriteLine($"{person} ");
// "Alice", "Tom", "Kate", "Bob", "Sam", "Tom"

var people3 = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

// уменьшим массив до 4 элементов
Array.Resize(ref people3, 4);

foreach (var person1 in people3)
    Console.WriteLine($"{person1} ");
// "Tom", "Sam", "Bob", "Kate"

var people4 = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

var employees1 = new string[3];

// копируем 3 элемента из массива people c индекса 1  
// и вставляем их в массив employees начиная с индекса 0
Array.Copy(people4, 1, employees1, 0, 3);

foreach (var person2 in employees1)
    Console.WriteLine($"{person2} ");
// Sam Bob Kate

var people5 = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

Array.Sort(people5);

foreach (var person3 in people5)
    Console.WriteLine($"{person3} ");

// Alice Bob Kate Sam Tom Tom