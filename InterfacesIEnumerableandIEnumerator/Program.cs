
using System.Collections;
/*
string[] people = { "Tom", "Sam", "Bob" };
//IEnumerator peopleEnumerator = people.GetEnumerator(); // получаем IEnumerator
while (peopleEnumerator.MoveNext())   // пока не будет возвращено false
{
    string item = (string)peopleEnumerator.Current; // получаем элемент на текущей позиции
    Console.WriteLine(item);
}
peopleEnumerator.Reset(); // сбрасываем указатель в начало массива
*/


Week week = new Week();
foreach (var day in week)
{
    Console.WriteLine(day);
}
class WeekEnumerator : IEnumerator
{
    string[] days;
    int position = -1;
    public WeekEnumerator(string[] days) => this.days = days;
    public object Current
    {
        get
        {
            if (position == -1 || position >= days.Length)
                throw new ArgumentException();
            return days[position];
        }
    }
    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }
    public void Reset() => position = -1;
}
class Week
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };
    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
}

public interface IEnumerable
{
    IEnumerator GetEnumerator();
}
public interface IEnumerator
{
    bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
    object Current { get; }  // текущий элемент в контейнере
    void Reset(); // перемещение в начало контейнера
}




