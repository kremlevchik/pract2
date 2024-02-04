//  Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
    Console.WriteLine("Введите натуральное число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 
        if (N <= 0) 
        { 
            Console.WriteLine("Число должно быть натуральным"); 
        } 
        else 
        { 
            string digits = ""; 
 
            while (N > 0) 
            { 
                int digit = N % 10; 
                digits = digit + ", " + digits; 
                N /= 10; 
            } 
 
            digits = digits.Remove(digits.Length - 2); // Удаляем лишнюю запятую и пробел в конце 
 
            Console.WriteLine($"Цифры числа через запятую: {digits}");
        }