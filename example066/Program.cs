// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120

// M = 4; N = 8. -> 30

int GetValueFromUser(string text)
{
    bool flag = false;
    int value = 0;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
    }
    return value;
}

int GetResultSumInRange(int firstValue, int secondValue)
{
    int sum = 0;
    while(firstValue < 0) firstValue++;
    if(firstValue == secondValue) return secondValue;
    else return sum = firstValue + GetResultSumInRange(firstValue + 1, secondValue);
}

int CheckDataRange(int firstValue, int secondValue)
{
    if(firstValue < secondValue) return GetResultSumInRange(firstValue, secondValue);
    else return GetResultSumInRange(secondValue, firstValue);
}

int firstValue = GetValueFromUser("Введите диапазон от: ");
int secondValue = GetValueFromUser("Введите диапазон до: ");

Console.WriteLine(CheckDataRange(firstValue, secondValue));

// Дмитрий, это мой лучший код в плане оптимизации.
// Пожалуйста, оставьте обратную связь по поводу "чистоты написания".
// Спасибо.
