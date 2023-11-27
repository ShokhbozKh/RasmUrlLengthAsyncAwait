using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.Write("RASM URLNI YUKLANG:");
        string url = Console.ReadLine();
        byte[] result = await PictureResult(url);
        Console.WriteLine($"RAsm Xajmi:{result.Length/1024} kbyte");
    }
    static async Task<byte[]> PictureResult(string url)
    {
        using(HttpClient client = new HttpClient())
        {
            byte[] response = await client.GetByteArrayAsync(url);
            return response;
        }
    }
}
