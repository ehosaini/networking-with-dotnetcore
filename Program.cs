using System;
using System.Net;
using System.Threading;

namespace networking_with_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleUri = Uri.GetSimpleUri();
            Console.WriteLine(simpleUri.ToString());
            Thread.Sleep(10000);
        }
    }
}
