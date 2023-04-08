// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArray(int Length, int min, int max)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min,max + 1);
}
return numbers;
}

void PrintArray(int [] numbers)
{
Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    Console.Write(numbers[i] + "; ");
}
Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
    Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

void Even(int [] numbers)
{
    int Summa = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(i % 2 != 0)
        {
            Summa += numbers[i];
        }
    }
    Console.WriteLine(Summa);
}

int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
Even(numbers);
