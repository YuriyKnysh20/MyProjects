

var person = new Person("Tom");
person.Name = "Bob";
Console.WriteLine(person.Name); // Bob - данные изменились
/*
var person1 = new Person2("Tom");
person1.Name = "Bob"; // ! ошибка - свойство изменить нельзя
*/
//Неизменяемые свойства
var person1 = new Person3("Tom");
var person2 = new Person3("Tom");
Console.WriteLine(person1.Equals(person2)); // true

var user1 = new User("Tom");
var user2 = new User("Tom");
Console.WriteLine(user1.Equals(user2));     // false


var person3 = new Person("Tom");
var person4 = new Person("Tom");
Console.WriteLine(person3 == person4); // true

var user3 = new User("Tom");
var user4 = new User("Tom");
Console.WriteLine(user3 == user4);     // false
//Оператор with
var tom = new Person4("Tom", 37);
var sam = tom with { Name = "Sam" };
Console.WriteLine($"{sam.Name} - {sam.Age}"); // Sam - 37

var person5 = new Person5();
var person6 = person5 with { };

var person7 = new Person6("Tom", 37);
Console.WriteLine(person7); // Person {Name = Tom, Age = 37}

public record Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}
public record struct Person1
{
    public string Name { get; set; }
    public Person1(string name) => Name = name;
}
public record Person2
{
    public string Name { get; init; }
    public Person2(string name) => Name = name;
}
public record Person3
{
    public string Name { get; init; }

    public Person3(string name) => Name = name;
}
public record Person4
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person4(string name, int age)
    {
        Name = name; Age = age;
    }
}
public  record Person5
{
    public string Name { get; set; }
    public int Age { get; init; }
    public Person5(string name,int age)
    {
        Name=name; Age = age;
    }

    public Person5()
    {

    }
}


public record Person6(string Name, int Age);
public class User
{
    public string Name { get; init; }
    public User(string name) => Name = name;
}
