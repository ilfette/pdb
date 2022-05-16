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
            store.subscribe(new CustomerA("Коля"));
            store.subscribe(new CustomerB("Сергей"));

            stopWatch.Start();
            store.notify(100, "Скидки");
            store.notify(100, "Новый товар!");
            stopWatch.Stop();

            Assert.IsTrue(stopWatch.Elapsed.TotalMilliseconds >= 200);
            Assert.IsTrue(stopWatch.Elapsed.TotalSeconds < 300);
        }

    }
}