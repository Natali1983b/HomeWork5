// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] CreateArray(int Length)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100,1000);
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
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            count ++;
        }
    }
    Console.WriteLine(count);
}

int Length = Num("длину массива");
int [] numbers = CreateArray(Length);
PrintArray(numbers);
Even(numbers);
