


Console.WriteLine("Въведете a");
int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Въведохте a = " + a);
Console.WriteLine("Въведете b");
int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Въведохте b = " + b);
if ( !((a<-3)||(a>2))||((b<5)&&(b>7)) )   //da ne se polzva tazi formula che ne e intuitivno
{
    Console.WriteLine( "стойност а е в интервала [-3;2] и b е в интервала [5;7] ");
}
else 
{
    Console.WriteLine( "стойностите не са в интервалите [-3;2] и [5;7]");
}