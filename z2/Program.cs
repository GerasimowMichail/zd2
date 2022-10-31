// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("ВВедите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = x / 100;
int i = 1;
int j = 1;
int q = 1;
int z = 10;
int res;
if ((x / 10) > 10)
{
    Console.WriteLine($"Введенное число {x} трехзначное или больше");
    while ((x / i) > 10)
    {
        i = i * 10;
        j += 1;
    }

    while (q < (j - 2))
    {
        q = q + 1;
        z = z * 10;

    }   
    res = ((x % z) / (z / 10));
    Console.WriteLine($"Третье число слева {res} ");

}

else
    Console.WriteLine("третьей цифры нет");


