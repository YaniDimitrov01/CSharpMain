// See https://aka.ms/new-console-template for more information
//int [] arr = {10,18,-54,4,2};
//foreach (int number in arr )
//{
//    Console.WriteLine(number);           //Primer1
//}
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter element[{i}]=");
    arr[i] = int.Parse(Console.ReadLine());
}
//foreach (int number in arr )
//{                                  //Primer2
//    Console.WriteLine(number);
//}
Console.WriteLine("---------foreach--------");

foreach (int number in arr)
{
    Console.WriteLine(number);
}

Console.WriteLine("---------for--------");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"arr[{i}] = {arr[i]}");
}
