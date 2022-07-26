int Akkerman (int m, int n)
{
    if (m==0)
        {
            return n+1;
        }
    else if(m>0&&n==0)
        {
            return Akkerman(m-1,1);
        }
    else
    {
       return Akkerman (m-1, Akkerman(m,n-1));
    }
    
}
Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());
int result = Akkerman(m,n);
Console.WriteLine(result);