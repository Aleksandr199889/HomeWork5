// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.3 7.76 22 2 78.67] -> 76.67

Console.Write("Введите число, ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

for(int i = 0; i < size; i++)
{
    numbers[i] =  new Random().Next(-100, 100);
}


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int Max = 0;
int Min = 0;
for( int i = 0; i < size; i++)
{
 if (Max < numbers[i]) 
 {
    Max = numbers[i];
 }
 if (Min > numbers[i])
 {
    Min = numbers[i];
 }
}

PrintArray(numbers);
Console.Write(Max-Min);
