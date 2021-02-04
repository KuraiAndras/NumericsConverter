using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace NumericsConverter.Benchmark
{
    [SimpleJob(RuntimeMoniker.Net472)]
    [MemoryDiagnoser]
    public class VectorBenchmark
    {
        [Benchmark]
        public void Alloc()
        {
            for (var i = 0; i < 100000; i++)
            {
                ConvertAlloc(new UnityEngine.Vector4(1f, 2f, 3f, 4f));
            }
        }

        [Benchmark]
        public void NoAlloc()
        {
            for (var i = 0; i < 100000; i++)
            {
                new UnityEngine.Vector4(1f, 2f, 3f, 4f).ToSystemGeneric();
            }
        }

        public static System.Numerics.Vector<float> ConvertAlloc(UnityEngine.Vector4 vector)
        {
            var array = new float[System.Numerics.Vector<float>.Count];
            array[0] = vector.x;
            array[1] = vector.y;
            array[2] = vector.z;
            array[3] = vector.w;

            return new System.Numerics.Vector<float>(array);
        }
    }
}