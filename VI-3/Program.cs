using (StreamReader reader = new StreamReader("text.txt"))
{
    string s =  reader.ReadToEnd();
    Console.WriteLine(s);
}   // обекта за еднократна употреба reader се освобождава след '}'
