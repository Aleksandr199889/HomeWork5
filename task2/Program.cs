// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sum = 0;
for( int i = 0; i < size; i++)
{
 if (i%2!=0) 
 {
    sum = sum + numbers[i];
 }
}

PrintArray(numbers);
Console.Write(sum);