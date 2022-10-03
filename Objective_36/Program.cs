//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);

int sum = 0;

for (int i = 1; i < numbers.Length; i+=2) 
    {
        sum = sum + numbers[i];
    }
Console.WriteLine($"Массив из {numbers.Length} элементов, cумма значений элементов на нечетных позициях {sum}");

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


