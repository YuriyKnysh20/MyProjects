string name = "Tom";
int age = 23;
string output = string.Format("Имя: {0}  Возраст: {1}", name, age);
Console.WriteLine(output);

double number = 23.7;
string result = string.Format("{0:C0}", number);
Console.WriteLine(result); // 24 р.
string result2 = string.Format("{0:C2}", number);
Console.WriteLine(result2); // 23,70 р.

int numbers = 23;
string results = string.Format("{0:d}", numbers);
Console.WriteLine(results); // 23
string results1 = string.Format("{0:d4}", numbers);
Console.WriteLine(results1); // 0023


int number1 = 23;
string result3 = string.Format("{0:f}", number1);
Console.WriteLine(result3); // 23,00

double number2 = 45.08;
string result4 = string.Format("{0:f4}", number2);
Console.WriteLine(result4); // 45,0800

double number3 = 25.07;
string result5 = string.Format("{0:f1}", number3);
Console.WriteLine(result5); // 25,1

decimal numbers1 = 0.15345m;
Console.WriteLine("{0:P1}", numbers1);// 15,3%

long numbers2 = 79876543210;
string resultate = string.Format("{0:+# (###) ###-##-##}", numbers2);
Console.WriteLine(resultate); // +7 (987) 654-32-10

long numbers3 = 19876543210;
Console.WriteLine(numbers3.ToString("+# (###) ###-##-##"));// +1 (987) 654-32-10

double money = 24.8;
Console.WriteLine(money.ToString("c2")); // 24,80 р.

//Интерполяция строк

string name1 = "Tom";
int age1 = 23;

Console.WriteLine($"Имя: {name1}  Возраст: {age1}");


int x = 8;
int y = 7;
string resultate1 = $"{x} + {y} = {x + y}";
Console.WriteLine(resultate1); // 8 + 7 = 15

int x1 = 8;
int y1 = 7;
string resultate2 = $"{x1} * {y1} = {Multiply(x1, y1)}";
Console.WriteLine(resultate2); // 8 * 7 = 56

int Multiply(int a, int b) => a * b;

string name2 = "Tom";
int age2 = 23;

Console.WriteLine($"Имя: {name2,-5} Возраст: {age2}"); // пробелы после
Console.WriteLine($"Имя: {name2,5} Возраст: {age2}"); // пробелы до