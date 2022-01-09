
var people = new Stack<string>();
people.Push("Tom");
// people = { Tom }
people.Push("Sam");
// people = { Sam, Tom }
people.Push("Bob");
// people = { Bob, Sam, Tom }

// получаем первый элемент стека без его удаления 
string headPerson = people.Peek();
Console.WriteLine(headPerson);  // Bob

string person1 = people.Pop();
// people = { Sam, Tom }
Console.WriteLine(person1);  // Bob

string person2 = people.Pop();
// people = { Tom }
Console.WriteLine(person2);  // Sam

string person3 = people.Pop();
// people = { }
Console.WriteLine(person3);  // Tom


var people1 = new Stack<string>();
people1.Push("Tom");
// people = { Tom }

// удаляем элементы
var success1 = people1.TryPop(out var person4);  // success1 = true
if (success1) Console.WriteLine(person1); // Tom

var success2 = people1.TryPeek(out var person5);  // success2 = false
if (success2) Console.WriteLine(person2);
