// *Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

// m = 3, n = 2 -> A(m,n) = 29

int GetValueFromUser(string text)
{
    bool flag = false;
    int value = 0;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (value >= 0)
        {
            Console.WriteLine("Необходимо ввести отрицательное число меньше 0.");
            flag = false;
        }
    }
    return value;
}

int GetAckResult(int firstValue, int secondValue)
{
    if (firstValue == 0)
        return secondValue + 1;
    else
    if ((firstValue != 0) && (secondValue == 0))
        return GetAckResult(firstValue - 1, 1);
    else
        return GetAckResult(firstValue - 1, GetAckResult(firstValue, secondValue - 1));
}

int firstValue = GetValueFromUser("Введите первое отрицательное число Аккермана: ");
int secondValue = GetValueFromUser("Введите второе отрицательное число Аккермана: ");
Console.WriteLine(GetAckResult(firstValue, secondValue));

// Взял формулу функции с Вики, не работает, (стак оверфлоу, не решил...)