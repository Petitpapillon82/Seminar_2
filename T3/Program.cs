//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то ппрограмма выводит остаток от деления.
 // 34, 5 -> не кратно, остаток 4
 // 16, 4 -> кратно 

Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(a % b == 0 ? "Кратное" : $"Не кратно, остаток {a%b}");




//Console.Clear();
//Console.WriteLine("Введите первое число:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 % num2 == 0)
//{
    // Console.WriteLine("Кратно");
//} 
//else
//{
  //  Console.Write(num1);
    //Console.WriteLine(num2);
    //Console.Write("Не кратно. Остаток:");
    //Console.WriteLine("num1 % num2");
//}