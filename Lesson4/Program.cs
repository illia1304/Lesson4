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

bool TrySumIfOdd(out int sum, int number1, int number2)
{
    int t = number1;
    sum = 0;
    if (number1 == number2)
    {
        sum = number1;
    }
    else
    {
        number1 = number2;
        number2 = t;
    }
    for (int i = number1; i <= number2; i++)
    {
        sum += i;
    }

    return sum % 2 == 0;
}


Console.WriteLine("Enter first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int b = int.Parse(Console.ReadLine());




Console.WriteLine($"sum of numbers {a} and {b} is odd? {TrySumIfOdd(out sum,a,b)}");