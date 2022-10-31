// Напишите программу, которая принимает на вход целое число любой разрядности число 
// и удаляет вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя.3    

Console.WriteLine("ВВедите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = x / 100;
int i = 1;
int j = 1;
int q = 1;
int z = 10;
int res;
int res1;
if ((x / 10) > 10)
{
    Console.WriteLine($"Введенное число {x} трехзначное или больше");
    while ((x / i) > 10)
    {
        i = i * 10;
        j += 1;
    }

    while (q < (j ))
    {
        q = q + 1;
        z = z * 10;

    }   
    res = ((x % z) / (z / 10));
    Console.WriteLine($"первое число слева {res}" +  ((x % (z/100)) ) );

}

else
    Console.WriteLine("третьей цифры нет");

