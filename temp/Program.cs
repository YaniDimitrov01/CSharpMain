// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете температура в целзий");
double TC = double.Parse(Console.ReadLine());
Console.WriteLine("Темп в фаренхяйт = " + ( (TC * 4.5) + 32 ) );