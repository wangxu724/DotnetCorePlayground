using System;
using System.Threading.Tasks;
using DotnetCorePlayground.Examples;

namespace DotnetCorePlayground
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to .net core playground!\n");

            var foreachAsyncExammple = new ForeachAsyncExamples();
            await foreachAsyncExammple.Run();
        }
    }
}
