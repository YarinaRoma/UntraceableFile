int InNum(int number)
{
    int sum = 0;
    while(number > 0)
    {
       number = number /10; 
       sum += 1;
    }
    return sum;
}
Console.Write(" Input a number :");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(InNum(a));

