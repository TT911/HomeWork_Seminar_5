//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 1; i < numbers.Length; i++) 
    {
        if (numbers[i] > max) max = numbers[i];
        if (numbers[i] < min) min = numbers[i];    
    }
Console.WriteLine($"Разница между максимальным и минимальным значением {max-min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++) 
    {
        numbers[i] = new Random().NextDouble()*(100-0)+0; //решение отсюда https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
