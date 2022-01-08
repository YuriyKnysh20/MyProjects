List<string> people = new List<string>();

List<Person> people1 = new List<Person>()
{
    new Person("Tom"),
    new Person("Bob"),
    new Person("Sam")
};
var people2 = new List<string>() { "Tom", "Bob", "Sam" };

string firstPerson = people2[0]; // получаем первый элемент
Console.WriteLine(firstPerson); // Tom
people2[0] = "Mike";     // изменяем первый элемент
Console.WriteLine(people2[0]); // Mike
//Перебор списка
var people3 = new List<string>() { "Tom", "Bob", "Sam" };

foreach (var person in people3)
{
    Console.WriteLine(person);
}

List<string> people4 = new List<string>() { "Tom" };

people4.Add("Bob"); // добавление элемента
                   // people = { "Tom", "Bob" };

people4.AddRange(new[] { "Sam", "Alice" });   // добавляем массив
                                             // people = { "Tom", "Bob", "Sam", "Alice" };
                                             // также можно было бы добавить другой список
                                             // people.AddRange(new List<string>(){ "Sam", "Alice" });

people4.Insert(0, "Eugene"); // вставляем на первое место
                            // people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };

people4.InsertRange(1, new string[] { "Mike", "Kate" }); // вставляем массив с индекса 1
// people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };

// также можно было бы добавить другой список
// people.InsertRange(1, new List<string>(){ "Mike", "Kate" });
//</ string ></ string >

//Удаление из списка
var people5 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

people5.RemoveAt(1); //  удаляем второй элемент
                    // people = { "Eugene", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

people5.Remove("Tom"); //  удаляем элемент "Tom"
                      // people = { "Eugene", "Kate", "Bob", "Sam", "Tom", "Alice" };

// удаляем из списка все элементы, длина строки которых равна 3
people5.RemoveAll(person => person.Length == 3);
// people = { "Eugene", "Kate", "Alice" };

// удаляем из списка 2 элемента начиная с индекса 1
people5.RemoveRange(1, 2);
// people = { "Eugene"};

// полностью очищаем список
people5.Clear();
// people = {  };



var people6 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

var containsBob = people6.Contains("Bob");     //  true
var containsBill = people6.Contains("Bill");    // false

// проверяем, есть ли в списке строки с длиной 3 символа
var existsLength3 = people6.Exists(p => p.Length == 3);  // true

// проверяем, есть ли в списке строки с длиной 7 символов
var existsLength7 = people6.Exists(p => p.Length == 7);  // false

// получаем первый элемент с длиной в 3 символа
var firstWithLength3 = people6.Find(p => p.Length == 3); // Tom

// получаем последний элемент с длиной в 3 символа
var lastWithLength3 = people6.FindLast(p => p.Length == 3);  // Sam

// получаем все элементы с длиной в 3 символа в виде списка
List<string> peopleWithLength3 = people6.FindAll(p => p.Length == 3);
// peopleWithLength3 { "Tom", "Bob", "Sam"}

List<string> people7 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

// получаем диапазон со второго по четвертый элемент
var range = people7.GetRange(1, 3);
// range = { "Tom", "Mike", "Sam"};

// копируем в массив первые три элемента
string[] partOfPeople = new string[3];
people7.CopyTo(0, partOfPeople, 0, 3);
// partOfPeople = { "Eugene", "Tom", "Mike"};


var people8 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

// переворачиваем весь список
people8 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
// переворачиваем часть только 3 элемента с индекса 1
people8.Reverse(1, 3);
// people2 = { "Eugene","Sam", "Mike", "Tom", "Bob" };

List<string> people9 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

// получаем диапазон со второго по четвертый элемент
var range1 = people9.GetRange(1, 3);
// range = { "Tom", "Mike", "Sam"};

// копируем в массив первые три элемента
string[] partOfPeople1 = new string[3];
people9.CopyTo(0, partOfPeople1, 0, 3);
// partOfPeople = { "Eugene", "Tom", "Mike"};

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}