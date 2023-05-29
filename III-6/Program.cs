// See https://aka.ms/new-console-template for more information
/* public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hold my beer");
        Main(); // Извикваме функцията Main,
                // която извиква себе си, 
                // отново и отново до безкрайност
    }
} 
*/

public class Program
{
public static int SumR(int n)
{
    if (n == 1) // ако n стигнало до 1, се прекратява 
    {           // изпълнението; условие за изход
        return 1;
    }
    else // ако n > 1, се връща текущата 
    {    // стойност на n + SumR(n - 1);
        return n + SumR(n - 1);
    }
}
// Употреба на рекурсивна функция :
int result = SumR(100);
Console.WriteLine(result); // Резултат: 5050
}