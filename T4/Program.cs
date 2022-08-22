//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
//14 -> нет
// 46 -> нет 
//161 -> да

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n % 7 == 0 && n % 23 == 0 ? "Да" : "Нет");

//Console.Clear();
// //int number = new Random().Next(100, 1000); 
// //Console.WriteLine(number);
//int number = 162;
// //Console.WriteLine(number % 23 == 0 && number % 7 ==0 ? $"Number {number} is aliquote to 7 and 23" : $"Number {number} is NOT aliquote to 7 and 23");
//if (number % 23 == 0 && number % 7 == 0)
//{
    //Console.WriteLine($"Number {number} is aliquote to 7 and 23");
//}
//else
//{
    //Console.WriteLine($"Number {number} is NOT aliquote to 7 and 23");
//}