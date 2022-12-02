/*
int CutNamber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    int result = sot * 10 + ed;
    return result;
}


int randNum = new Random().Next(100,1000);
int newNum = CutNamber(randNum);

Console.WriteLine($"New version of a number {randNum} is {newNum}");
*/

/*
int randnamber (int num)
{
    int des = num / 10;
    int ed = num % 10;
    int result = des > ed ? des : ed;
    return result;
}

int randnum = new Random().Next(10,100);

Console.WriteLine($"В числе {randnum} большая цифра {randnamber(randnum)}");



bool checknumb(int num, int a, int b)
{
    if(num % a == 0 && num % b == 0)
    return true;
    else 
        return false;
}
Console.WriteLine($"Число {checknumb(8, 3, 4)} ");



bool checkquad(int a, int b)
{
    if(Math. Pow(a, 2) == b || Math. Pow(b, 2) == a)
    return true;
    else 
        return false;

}
Console.WriteLine($"Число {checkquad(2, 4)} ");
*/