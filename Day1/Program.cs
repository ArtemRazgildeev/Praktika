Console.WriteLine("Task №1");
string str1 = "Hello";
string str2 = "World";
Console.WriteLine(str1 + " " + str2);


Console.WriteLine("Task №2");
double perem1 = 10;
double perem2 = 5;
Console.WriteLine("Сложение: " + (perem1 + perem2));
Console.WriteLine("Вычитание: " + (perem1 - perem2));
Console.WriteLine("Деление: " + (perem1 / perem2));
Console.WriteLine("Умножение: " + (perem1 * perem2));


Console.WriteLine("Task №3");
Console.WriteLine("Введите имя: ");
string name = Console.ReadLine();
Console.WriteLine("Введите фамилию: ");
string familiya = Console.ReadLine();
Console.WriteLine("Введите отчество: ");
string otchesvo = Console.ReadLine();
Console.WriteLine($"{name} {familiya} {otchesvo}");


Console.WriteLine("Task №4");
double healthP = 100;
double damageP = 15;
double bronyaP = 5;
double healthM = 120;
double damageM = 10;
double bronyaM = 3;
double healthostP = damageM / bronyaP;
double healthostM = damageP / bronyaM;
Console.WriteLine("Здоровья осталось у игрока: " + (healthostP));
Console.WriteLine("Здоровь осталось у монстра: " + (healthostM));
Console.WriteLine("Урона нанес игрок: " + (healthM - healthostM));
Console.WriteLine("Урона нанес монстр: " + (healthP - healthostP));
Console.ReadKey();