using BenchmarkDotNet.Attributes;
using System;

namespace BenchmarkDotNet.Samples.NetCore2
{
    public class SpanFill
    {
        private byte[] array;

        [Params(10, 100, 1000)]
        public int Length { get; set; }

        [Setup]
        public void Setup()
        {
            array = new byte[Length];
        }

        [Benchmark()]
        public void TestSpanFillByte()
        {
            var span = new Span<byte>(array);
            span.Fill(default(byte));
        }
    }
}
