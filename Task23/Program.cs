//Задача 23: Напишите программу, 
//которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите натуральное число: ");

if (number > 0) PrintSqr(number);
else Console.WriteLine("Введено не натуральное число. Начните заново.");

void PrintSqr(int num)
{
    Console.WriteLine("Число    Куб числа");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i,5}   {i * i * i,5}");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
