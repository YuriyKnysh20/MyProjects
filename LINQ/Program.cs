string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

var selectedTeams = from t in teams // определяем каждый объект из teams как t
                    where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                    orderby t  // упорядочиваем по возрастанию
                    select t; // выбираем объект

foreach (string s in selectedTeams)
    Console.WriteLine(s);

int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

IEnumerable<int> evens = from i in numbers
                         where i % 2 == 0 && i > 10
                         select i;
foreach (int i in evens)
    Console.WriteLine(i);

List<User> users = new List<User>
{
    new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
    new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
    new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
    new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};

var selectedUsers = from user in users
                    where user.Age > 25
                    select user;
foreach (User user in selectedUsers)
    Console.WriteLine($"{user.Name} - {user.Age}");

// выборка имен
var names = users.Select(u => u.Name);

// выборка объектов анонимного типа
var items = users.Select(u => new
{
    FirstName = u.Name,
    DateOfBirth = DateTime.Now.Year - u.Age
});
//Оператор let
List<User> users1 = new List<User>()
{
    new User { Name = "Sam", Age = 43 },
    new User { Name = "Tom", Age = 33 }
};

var people = from u in users1
             let name = "Mr. " + u.Name
             select new
             {
                 Name = name,
                 Age = u.Age
             };



 List<User> users2 = new List<User>()
{
    new User { Name = "Sam", Age = 43 },
    new User { Name = "Tom", Age = 33 }
};
List<Phone> phones = new List<Phone>()
{
    new Phone {Name="Lumia 630", Company="Microsoft" },
    new Phone {Name="iPhone 6", Company="Apple"},
};

var people1 = from user in users2
             from phone in phones
             select new { Name = user.Name, Phone = phone.Name };

foreach (var p in people1)
    Console.WriteLine($"{p.Name} - {p.Phone}");
class User
{
    public string Name { get; set; }

    public int Age { get; set; }
    public List<string> Languages { get; set; }
    public User()
    {
        Languages = new List<string>();
    }
}
class Phone
{
    public string Name { get; set; }
    public string Company { get; set; }
}
