//first
int MaxInt(int number1, int number2, int number3, int max)
{
    max = Math.Max(Math.Max(number1, number2), number3);
    return max;
}

//second
int MinInt(int number1, int number2, int number3, int min)
{
    min = Math.Min(Math.Min(number1, number2), number3);
    return min;
}

//third
int SumInt(ref int number1, ref int number2)
{
    int temp = number2;
    int sum = 0;

    if (number1 == number2)
    {
        sum = number2;
    }
    else if (number2 < number1)
    {
        temp = number1;
        for (int i = number2; i <= temp; i++)
        {
            sum += i;
        }
    }
    else
    {
        for(int i = number1; i <= temp; i++)
        {
            sum += i;
        }
    }
    return sum;
}
bool TrySumIfOdd(ref int sum, bool isOdd)
{
    if(sum % 2 != 0)
        isOdd = true;
    return isOdd;
}


Console.WriteLine("Enter first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int b = int.Parse(Console.ReadLine());
bool sumIsOdd = false;

int sum = SumInt(ref a, ref b);

Console.WriteLine($"sum of numbers {a} and {b} is odd? {TrySumIfOdd(ref sum, sumIsOdd)}");