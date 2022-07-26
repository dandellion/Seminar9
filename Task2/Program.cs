void PrintNumber (int m, int n, int s)
{
    if (m<=n)
        {
            s=s+m;
            PrintNumber(m+1, n, s);
        }
    else 
    {
        Console.Write(s);
    }
}
Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());
int sum = 0;
PrintNumber(m,n, sum);