using NUnit.Framework;
using System.Diagnostics;

namespace TestTask2_2
{
    public class Tests
    {

        [Test]
        public void TestCountDownWithTwoSubscribers()
        {
            Stopwatch stopWatch = new Stopwatch();
           Countdown store = new Countdown();
            store.subscribe(new CustomerA("����"));
            store.subscribe(new CustomerB("������"));

            stopWatch.Start();
            store.notify(100, "������");
            store.notify(100, "����� �����!");
            stopWatch.Stop();

            Assert.IsTrue(stopWatch.Elapsed.TotalMilliseconds >= 200);
            Assert.IsTrue(stopWatch.Elapsed.TotalSeconds < 300);
        }

    }
}