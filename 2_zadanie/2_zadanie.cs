// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] array = new int[4];
Console.WriteLine("Введите числа b1, k1, b2, k2 через кнопку Enter: ");
for (int i = 0; i < array.Length; i++)
{
    int number = int.Parse(Console.ReadLine());
    array[i] = number;
}

void outputSkrin()
{
    Console.Write("Массив данных: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine(" ");

outputSkrin();

Console.WriteLine(" ");

double x_1 = (array[2] - array[0]);
Console.WriteLine($"Точка X_1 равно: {x_1}");
double x_2 = (array[1] - array[3]);
Console.WriteLine($"Точка X_2 равно: {x_2}");
double x = x_1 / x_2;
Console.WriteLine($"Точка X равно: {x}");
double y = (array[1] * x) + array[0];
Console.WriteLine($"Точка Y равно: {y}");
