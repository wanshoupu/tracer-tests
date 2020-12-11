using System;
using System.Threading;
using NUnit.Framework;

namespace Tracing.Tests
{
    [SingleThreaded]
    public class TracerNetworkTest : TracerTestBase
    {
        [SetUp]
        public void SetUp()
        {
            Iter = 10;
            Chunk = 2;
            BufferSize = 2;
            ReportPeriod = .5;
        }

        [Test, Order(1)]
        public void TestExecute_Localhost()
        {
            Host = "localhost";
            Execute(ExplicitFinish);
            Thread.Sleep(TimeSpan.FromSeconds(20));
        }

        [Test, Order(2)]
        public void TestExecute_GarbageHost()
        {
            Host = "garbage";
            Execute(FinishOnDispose);
        }
    }
}