using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace NumericsConverter.Benchmark
{
    public class Program
    {
        [System.Obsolete]
        public static void Main() =>
            BenchmarkRunner.Run<VectorBenchmark>(
                ManualConfig
                    .Create(DefaultConfig.Instance)
                    .With(ConfigOptions.DisableOptimizationsValidator));
    }
}