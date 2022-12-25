
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) // генерирует массив с заданными параметрами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write("] ");
    Console.WriteLine();
}
*/

//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
void ReversArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.WriteLine("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ; ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
ReversArray(myArray);
ShowArray(myArray);
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool IsTriangle(int first, int second, int third)
{
    return first < second + third && second < first + third && third < second + first;
}   

Console.WriteLine("Please enter first side: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second side: ; ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter third side: ");
int third = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(first, second, third);
string answer = result == true? "Triangle can be": "Triangle cannot be";
Console.WriteLine(answer);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*
int[] Fibonacci(int a, int b, int size)
{
    int[] fibArray = new int[size];
    fibArray[0] = a;
    fibArray[1] = b;
    for (int i = 2; i < size; i++)
    {
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
    }
    return fibArray;
}
Console.WriteLine("Please, enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter first value: ; ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second value: ");
int second = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonacci(first, second, size);
ShowArray(myArray);
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    return copyArray;
}

Console.WriteLine("Please, enter size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter min value of an array: ; ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter max value of an array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
int[] copyArray = CopyArray(myArray);

ShowArray(myArray);
ShowArray(copyArray);
*/




// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string DecToBin(int number)
{
    string bin = String.Empty;
    while(number > 0)
    {
        bin = number % 2 + bin;
        number /= 2;
    }
    return bin;
}

Console.WriteLine("Please, enter namber: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = DecToBin(number);
Console.Write(result);
*/
