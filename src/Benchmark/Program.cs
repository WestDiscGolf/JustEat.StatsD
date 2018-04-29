using BenchmarkDotNet.Running;

namespace Benchmark
{

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StatSendingBenchmark>();
            BenchmarkRunner.Run<FormatterBenchmark>();
        }
    }
}
