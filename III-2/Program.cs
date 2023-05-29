// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Въведохте a = " + a);
if (a%2==0) 
{
    Console.WriteLine(a + " e четно");
}
else 
{
    Console.WriteLine(a + " е нечетно");
}