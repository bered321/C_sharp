//Задача 0
/*Console.Clear();
int square = 0;
Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
square = n*n;
Console.WriteLine("Квадрат числа равен: " + square);*/

//Задача 1
/*Console.Clear();
Console.Write("Введите первое число: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); 
int n = Convert.ToInt32(Console.ReadLine());
if (square/n == n)
    Console.WriteLine("Число 1 является квадратом числа 2");
else
    Console.WriteLine("Число 1 не является квадратом числа 2");*/


//Задача 3
/*Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
}
if (n == 1)
    Console.WriteLine("Понедельник");
else if (n == 2)
    Console.WriteLine("Вторник");
else if (n == 3)
    Console.WriteLine("Среда");
else if (n == 4)
    Console.WriteLine("Четверг");
else if (n == 5)
    Console.WriteLine("Пятница");
else if (n == 6)
    Console.WriteLine("Суббота");
if (n == 7)
    Console.WriteLine("Воскресенье");*/

//Задача 5
/*Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = (-1) * n;;
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");
while (i < n)
{
    Console.Write($"{i} ");
    i++;
}*/

//Задача 7
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n%10);