// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] CreateArray(int Length, int min, int max)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min,max +1);
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
    Console.Write($"Введите {arg} ");
    return int.Parse(Console.ReadLine());
}

int MaxElement (int [] numbers)
{
    int maximum = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > maximum)
        {
            maximum = numbers[i];
        }
    }
    return maximum;
}

int MinElement (int [] numbers)
{
    int minimum = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < minimum)
        {
            minimum = numbers[i];
        }
    }
    return minimum;
}


int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
Console.Write("Максимальное число массива: ");
Console.WriteLine(MaxElement(numbers));
Console.Write("Минимальное число массива: ");
Console.WriteLine(MinElement(numbers));
Console.WriteLine($"Разница: {MaxElement(numbers) - MinElement(numbers)}");
