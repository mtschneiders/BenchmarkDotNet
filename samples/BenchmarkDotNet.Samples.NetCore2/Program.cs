using BenchmarkDotNet.Running;
using System.Reflection;

namespace BenchmarkDotNet.Samples.NetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(SpanFill).GetTypeInfo().Assembly).Run(args);
        }
    }
}
