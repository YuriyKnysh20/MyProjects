
User tom = new User("Tom", 35);
User bob = new User("Bob", 16);
bool tomIsValid = ValidateUser(tom);    // true
bool bobIsValid = ValidateUser(bob);    // false

Console.WriteLine($"Реультат валидации Тома: {tomIsValid}");
Console.WriteLine($"Реультат валидации Боба: {bobIsValid}");
Console.ReadLine();
 static bool ValidateUser(User user)
 {
        Type t = typeof(User);
        object[] attrs = t.GetCustomAttributes(false);
        foreach (AgeValidationAttribute attr in attrs)
        {
            if (user.Age >= attr.Age) return true;
            else return false;
        }
        return true;
 }
public class AgeValidationAttribute : System.Attribute
{
    public int Age { get; set; }

    public AgeValidationAttribute()
    { }

    public AgeValidationAttribute(int age)
    {
        Age = age;
    }
}
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public User(string n, int a)
    {
        Name = n;
        Age = a;
    }
}
