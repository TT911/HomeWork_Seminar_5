//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"Массив из {numbers.Length} элементов, {count} из них чётный(-ые)");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

