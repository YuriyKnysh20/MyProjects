
using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<string> people = new ObservableCollection<string>();

var people1 = new ObservableCollection<string>(new string[] { "Mike", "Alice", "Kate" })
{
    "Tom", "Bob", "Sam"
};
// получаем первый элемент
Console.WriteLine(people1[0]);   // Mike
// изменяем первый элемент
people1[0] = "Tomas";
Console.WriteLine(people1[0]);   // Tomas

foreach (var person in people1)
{
    Console.WriteLine(person);
}
for (int i = 0; i < people1.Count; i++)
{
    Console.WriteLine(people1[i]);
}

//Применение методов

var people2 = new ObservableCollection<string>();

// добавляем элемент
people2.Add("Bob");
// вставляем элемент по индексу 0
people2.Insert(0, "Tom");

// проверка наличия элемента 
bool bobExists = people2.Contains("Bob");     // true
Console.WriteLine($"Bob exists: {bobExists}");
bool mikeExists = people2.Contains("Mike");   // false
Console.WriteLine($"Mike exists: {mikeExists}");

// удаляем элемент
people2.Remove("Tom");
// удаляем элемент по индексу 0
people2.RemoveAt(0);




 
var people3 = new ObservableCollection<Person>()
{
    new Person("Tom"),
    new Person("Sam")
};
// подписываемся на событие изменения коллекции
people3.CollectionChanged += People_CollectionChanged;

people3.Add(new Person("Bob"));  // добавляем новый элемент

people3.RemoveAt(1);                 // удаляем элемент
people3[0] = new Person("Eugene");   // заменяем элемент

Console.WriteLine("\nСписок пользователей:");
foreach (var person in people3)
{
    Console.WriteLine(person.Name);
}
// обработчик изменения коллекции
void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add: // если добавление
            if (e.NewItems?[0] is Person newPerson)
                Console.WriteLine($"Добавлен новый объект: {newPerson.Name}");
            break;
        case NotifyCollectionChangedAction.Remove: // если удаление
            if (e.OldItems?[0] is Person oldPerson)
                Console.WriteLine($"Удален объект: {oldPerson.Name}");
            break;
        case NotifyCollectionChangedAction.Replace: // если замена
            if ((e.NewItems?[0] is Person replacingPerson) &&
                (e.OldItems?[0] is Person replacedPerson))
                Console.WriteLine($"Объект {replacedPerson.Name} заменен объектом {replacingPerson.Name}");
            break;
    }
}
class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}