using System;
namespace DotnetCorePlayground.Examples
{
    public class OtherExamples
    {
        public static void Test_TicksToDatetime()
        {
            var ticks = 637378626495269666;
            var dateTime = new DateTime(ticks).ToString("yyyy-MM-dd hh:mm:ss.fff tt");
            Console.WriteLine(dateTime);
        }

        public static void Test_DoubleQuestionMarkOperator()
        {
            Nullable<bool> a = false;
            var rlt = a ?? true;

            Console.WriteLine(rlt);
        }
    }
}
