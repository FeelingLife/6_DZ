// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] array = new int[5];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < array.Length; i++)
{
    int number = int.Parse(Console.ReadLine());
    array[i] = number;
}

void outputSkrin()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine(" ");
    }
}

outputSkrin();


int positiveNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveNumbers = positiveNumbers + 1;
    }

}
Console.WriteLine($"Количество положительных чисел: {positiveNumbers}");