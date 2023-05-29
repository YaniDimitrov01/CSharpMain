// See https://aka.ms/new-console-template for more information
//for (int i=0; i<100; i++) 
//for (int i=100; i>=0; i--) 
//for (double i=100; i>=0; i=i-0.25) 
for (int i=100; i>=0; i--) 
{
    if (i%2==0)
    {
        Console.WriteLine($" {i} е четно");
    } 
    else
    {
        Console.WriteLine($" {i} е нечетно");
    }
Thread.Sleep(500);
}