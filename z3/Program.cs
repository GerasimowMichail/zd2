// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("ВВедите число от 1 до 7");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x);
if (x==1) Console.WriteLine("Понедельник");
if (x==2) Console.WriteLine("Вторник");
if (x==3) Console.WriteLine("Среда");
if (x==4) Console.WriteLine("Четверг");
if (x==5) Console.WriteLine("Пятница");
if (x==6) Console.WriteLine("Суббота");
if (x==7) Console.WriteLine("Воскресенье");
else
Console.WriteLine($"Число {x} не является днем недели");
