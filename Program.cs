using System;
using System.Threading.Tasks;
using DotnetCorePlayground.Examples;

namespace DotnetCorePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to .net core playground!\n");

            //await ForeachAsyncExamples.Run();

            OtherExamples.Test_DoubleQuestionMarkOperator();

            OtherExamples.Test_TicksToDatetime();
        }
    }
}
