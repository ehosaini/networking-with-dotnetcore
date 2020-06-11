using System;
using System.Net;
using System.Threading;

namespace networking_with_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a syntatcially correct URL
            // var simpleUri = Uri.GetSimpleUri();
            // Console.WriteLine(simpleUri.ToString());
            
            // List IP Addressed
            var domainEntry = Dns.GetHostEntry("google.com");
            foreach(var ip in domainEntry.AddressList){
                Console.WriteLine(ip);
            }
            Thread.Sleep(1000);
        }
    }
}
