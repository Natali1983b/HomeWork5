// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(double[] numbers)
{
double low = Num("Enter lower limit");
double up = Num("Enter upper limit");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(new Random().NextDouble()*(up - low) + low, 2);
    Console.Write($"{numbers[i]} ");
}
return numbers;
}


double Num (string arg)
{
    Console.WriteLine($"Enter {arg} ");
    double argument = double.Parse(Console.ReadLine());
    return argument;
}

double MaxElement (double [] numbers)
{
    double maximum = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > maximum)
        {
            maximum = numbers[i];
        }
    }
    return maximum;
}

double MinElement (double [] numbers)
{
    double minimum = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < minimum)
        {
            minimum = numbers[i];
        }
    }
    return minimum;
}


double[] numbers = CreateArray(numbers);
Console.WriteLine(MaxElement(numbers));
Console.WriteLine(MinElement(numbers));
Console.WriteLine($"Difference: {MaxElement(numbers) - MinElement(numbers)}");