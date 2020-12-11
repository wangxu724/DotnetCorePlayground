using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetCorePlayground.Examples
{
    public class ForeachAsyncExamples
    {
        public static async Task Run()
        {
            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("This section shows foreach+async runs sequentially.");
            foreach (var num in nums)
            {
                Console.WriteLine($"num: {num}");
                var rlt = await getRandomNumberAsync();
                Console.WriteLine($"num: {num}; rlt: {rlt}");
            }

            Console.WriteLine("");
            Console.WriteLine("This section shows foreach+async+break will quit following runs.");
            foreach (var num in nums)
            {
                Console.WriteLine($"num: {num}");
                var rlt = await getRandomNumberAsync();
                Console.WriteLine($"num: {num}; rlt: {rlt}");
                if (rlt % 2 == 0)
                {
                    Console.WriteLine($"Break on {rlt}");
                    break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("This section shows foreach+async+exception-within-async will quit following runs.");
            try
            {
                foreach (var num in nums)
                {
                    Console.WriteLine($"num: {num}");
                    var rlt = await getRandomThrowAsync();
                    Console.WriteLine($"num: {num}; rlt: {rlt}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        private static Task<int> getRandomNumberAsync()
        {
            return Task<int>.Run(() =>
            {
                var rand = new Random();
                Thread.Sleep(1000);
                var rlt = rand.Next(0, 10);
                return rlt;
            });
        }

        private static Task<int> getRandomThrowAsync()
        {
            return Task<int>.Run(() =>
            {
                var rand = new Random();
                Thread.Sleep(1000);
                var rlt = rand.Next(0, 10);
                if (rlt % 2 == 0)
                {
                    throw new Exception("Got even number;");
                }
                return rlt;
            });
        }
    }
}
