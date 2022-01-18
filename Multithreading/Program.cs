using System.Threading;

{
    // получаем текущий поток
    Thread t = Thread.CurrentThread;

    //получаем имя потока
    Console.WriteLine($"Имя потока: {t.Name}");
    t.Name = "Метод Main";
    Console.WriteLine($"Имя потока: {t.Name}");

    Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
    Console.WriteLine($"Приоритет потока: {t.Priority}");
    Console.WriteLine($"Статус потока: {t.ThreadState}");

    // получаем домен приложения
    Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");
}