using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chpt15.AsyncConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //==========
            // 异步编程
            //
            PrintPageLength();
            Console.ReadLine();
        }

        static async Task<int> GetPageLengthAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                Task<string> fetchTask = client.GetStringAsync(url);
                int len = (await fetchTask).Length;
                return len;
            }
        }

        static void PrintPageLength()
        {
            Task<int> lenTask = GetPageLengthAsync("http://www.baidu.com");
            Console.WriteLine(lenTask.Result);
        }
    }
}
