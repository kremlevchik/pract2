//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
if (a % 7 == 0 || a % 23 == 0 ){
    System.Console.WriteLine("Число кратно");
}
else 
    System.Console.WriteLine("Число не кратно");