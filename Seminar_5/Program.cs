// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) // генерирует массив с заданными параметрами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) 
            sum += array[i];
    return sum;
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/
/*
int result = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements is" + (GetSumOfNegatives{sum}));
*/



// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] revers (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
*/
/*
int[] result = revers(myArray);
ShowArray(result);
*/

// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int Mult (int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b)
            count++;
    }
    return count;
}

Console.Write("Введите a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int numB = Convert.ToInt32(Console.ReadLine());

int number = Mult(myArray, numA, numB);
Console.WriteLine(number);
*/

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
int[] MultPairs(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0)
        size++;

    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
        
    }
    return newArray;
}

int[] result = MultPairs(myArray);
ShowArray(result);
*/




