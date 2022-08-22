Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine($"Число {numberA} - квадрат числа {numberB}");
}
else if (numberB == numberA * numberA)
{
   Console.WriteLine($"Число {numberB} - квадрат числа {numberA}"); 
}
else
{
   Console.WriteLine ("Квадрата нет");
}