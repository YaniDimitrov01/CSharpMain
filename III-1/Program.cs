// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Въведохте a = " + a);
if (a>0) 
{
    Console.WriteLine(a + " e положително");
}
else if (a<0) 
{
    Console.WriteLine(a + " е отрицателно ");
}
else 
{
    Console.WriteLine(a + " е нула");
}