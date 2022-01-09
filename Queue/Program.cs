var employees = new List<string> { "Tom", "Sam", "Bob" };
Queue<string> people = new Queue<string>(employees);
foreach (var person in people) Console.WriteLine(person);

Console.WriteLine(people.Count); // 3


var people1 = new Queue<string>();

// добавляем элементы
people1.Enqueue("Tom");  // people = { Tom }
people1.Enqueue("Bob");  // people = { Tom, Bob }
people1.Enqueue("Sam");  // people = { Tom, Bob, Sam }

// получаем элемент из самого начала очереди 
var firstPerson = people1.Peek();
Console.WriteLine(firstPerson); // Tom

// удаляем элементы
var person1 = people1.Dequeue();  // people = { Bob, Sam  }
Console.WriteLine(person1); // Tom
var person2 = people1.Dequeue();  // people = { Sam  }
Console.WriteLine(person2); // Bob
var person3 = people1.Dequeue();  // people = {  }
Console.WriteLine(person3); // Sam

var people2 = new Queue<string>();

// добавляем элементы
people.Enqueue("Tom");  // people = { Tom }

// удаляем элементы
var success1 = people2.TryDequeue(out var person4);  // success1 = true
if (success1) Console.WriteLine(person1); // Tom

var success2 = people2.TryPeek(out var person5);  // success2 = false
if (success2) Console.WriteLine(person2);


var patients = new Queue<Person>();
patients.Enqueue(new Person("Tom"));
patients.Enqueue(new Person("Bob"));
patients.Enqueue(new Person("Sam"));

var practitioner = new Doctor();
practitioner.TakePatients(patients);
//Очередь пациентов к врачу
class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Doctor
{
    public void TakePatients(Queue<Person> patients)
    {
        while (patients.Count > 0)
        {
            var patient = patients.Dequeue();
            Console.WriteLine($"Осмотр пациента {patient.Name}");
        }
        Console.WriteLine("Доктор закончил осматривать пациентов");
    }
}
