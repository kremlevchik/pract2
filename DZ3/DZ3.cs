Console.Write("Введите число от 10 до 99: ");
int i = int.Parse(Console.ReadLine()!);
while (i < 10 || i > 99){
    Console.WriteLine("Вы ошиблись! \nВведите корректное число: ");
    i = int.Parse(Console.ReadLine()!);
 }
 int number1 = i / 10;
 int number2 = i % 10;
    if (number1 > number2){
        System.Console.WriteLine("Первое чило больше");
    }
    else
    System.Console.WriteLine("Второе число больше");
     