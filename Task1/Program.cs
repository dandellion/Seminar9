void PrintNumber (int m, int n)
{
    
    if (m<n)
        {Console.Write($"{m} ");PrintNumber(m+1, n);}
    else {Console.Write(n);
   }
}
Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());

PrintNumber(m,n);