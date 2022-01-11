Numbers numbers = new Numbers();
foreach (int n in numbers)
{
    Console.WriteLine(n);
}


var people = new Person[]
{
    new Person("Tom"),
    new Person("Bob"),
    new Person("Sam")
};
var microsoft = new Company(people);

foreach (Person employee in microsoft)
{
    Console.WriteLine(employee.Name);
}

//Именованные итераторы

var people1 = new Person1[]
{
    new Person1("Mike"),
    new Person1("Alice"),
    new Person1("Sam")
};
var microsoft1 = new Company1(people1);

foreach (Person1 employee in microsoft1.GetPersonnel(5))
{
    Console.WriteLine(employee.Name);
}

class Numbers
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return i * i;
        }
    }
}


class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}
class Company
{
    Person[] personnel;
    public Company(Person[] personnel) => this.personnel = personnel;
    public int Length => personnel.Length;
    public IEnumerator<Person> GetEnumerator()
    {
        for (int i = 0; i < personnel.Length; i++)
        {
            yield return personnel[i];
        }
    }
}


class Person1
{
    public string Name { get; }
    public Person1(string name) => Name = name;
}
class Company1
{
    Person1[] personnel;
    public Company1(Person1[] personnel) => this.personnel = personnel;
    public int Length => personnel.Length;
    public IEnumerable<Person1> GetPersonnel(int max)
    {
        for (int i = 0; i < max; i++)
        {
            if (i == personnel.Length)
            {
                yield break;
            }
            else
            {
                yield return personnel[i];
            }
        }
    }
}
