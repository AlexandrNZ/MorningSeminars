// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumOfDigits(int num)
{
    int count = 0;
    if(num == 0) count = 1;
    while(num != 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($"Количество цифр в {number} равно {result}");


for (int current = -number; current <= number; current++)
{
    Console.Write("current + " ");
}
*/

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int SumNam(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num;
        num--;
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumNam(num);
Console.WriteLine($"Сумма чисел в {num} равно {result}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Product(int num)

{
    if(num < 0) num = num * -1;
    int prod = 1;
    while(num > 0)
    {
        prod *= num;
        num--;
    }
    return prod;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Product(num);
Console.WriteLine($"Произведение чисел от {num} равно {result}");
*/

int[] CreateRandomArrey(int size, int minValue, int maxValue) // генерирует массив с заданными параметрами
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is{array[i]}");
    }
}


Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArrey = CreateRandomArrey(size, min, max);
ShowArray(myArrey);
