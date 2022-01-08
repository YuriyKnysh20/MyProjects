
var employees = new List<string> { "Tom", "Sam", "Bob" };

LinkedList<string> people = new LinkedList<string>(employees);
foreach (string person in people)
{
    Console.WriteLine(person);
}

LinkedList<string> people1 = new LinkedList<string>(employees);
foreach (string person in people1)
{
    Console.WriteLine(person);
}

var employees1 = new List<string> { "Tom", "Sam", "Bob" };

LinkedList<string> people2 = new LinkedList<string>(employees1);
Console.WriteLine(people2.Count);            // 3
Console.WriteLine(people2.First?.Value);    // Tom
Console.WriteLine(people2.Last?.Value);    // Bob


LinkedList<string> people3 = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

// от начала до конца списка
var currentNode = people3.First;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}

// с конца до начала списка
currentNode = people3.Last;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Previous;
}


var people4 = new LinkedList<string>();
people4.AddLast("Tom"); // вставляем узел со значением Tom на последнее место
                       //так как в списке нет узлов, то последнее будет также и первым
people4.AddFirst("Bob"); // вставляем узел со значением Bob на первое место

// вставляем после первого узла новый узел со значением Mike
if (people4.First != null) people4.AddAfter(people4.First, "Mike");

// теперь у нас список имеет следующую последовательность: Bob Mike Tom
foreach (var person in people4) Console.WriteLine(person);


