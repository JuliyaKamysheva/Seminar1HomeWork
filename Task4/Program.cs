// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число a: ");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int numberc = Convert.ToInt32(Console.ReadLine());

if(numbera > numberb & numbera > numberc)
{
    Console.WriteLine(numbera);
}
else
{
    if (numberb > numbera & numberb > numberc)
{
    Console.WriteLine(numberb);
}

else
{
    Console.WriteLine(numberc);
}
}
