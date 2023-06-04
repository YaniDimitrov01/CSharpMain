using System.Text;

// низ на различни езици /UTF-8/, който ще запишем във файл 
string wStr = "Hold my beer, ビールを預けておいてください, Подержи мое пиво!";
Console.WriteLine("Original String: " + wStr); // Показване на оригиналния низ
string filePath = " output.txt";
// Записване на wStr във файл с име output.txt
using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
{
    writer.Write(wStr);
}

// Четене на rStr от същия файл /output.txt/
string rStr;
using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
{
    rStr = reader.ReadToEnd();
}
Console.WriteLine("Read String: " + rStr); // Показване на прочетения низ
