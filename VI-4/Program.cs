using System;
using System.Net.Http; // необходимо заради HttpClient обекта
class Program
{
    // функцията Main е асинхронна, във II Част на курса ще 
    // бъде разгледана по-подробно
    static async System.Threading.Tasks.Task Main()
    {
      //  HttpClient client = new HttpClient();
      //  string url = "https://jsonplaceholder.typicode.com/posts";
        try
        {
            double b = 0;
            double a = 5 / b;
        }
    //    {
    //        string response = await client.GetStringAsync(url);
    //        // await - във II Част
    //        Console.WriteLine("Response: " + response);
    //    }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
             Console.WriteLine("Finally");
            //client.Dispose();
        }
    }
}
