// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetValueFromUser(string text)
{
    bool flag = false;
    int value = 0;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (value <= 0)
        {
            Console.WriteLine("Необходимо ввести натуральное число больше 0.");
            flag = false;
        }
    }
    return value;
}

void GetResult(int value)
{
    Console.Write($"{value} ");
    if(value == 1) return;
    else GetResult(value - 1);
}

int value = GetValueFromUser("Введите натуральное число: ");

GetResult(value);

