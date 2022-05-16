using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int delay;
            Console.WriteLine("Задержка:");
            Countdown store = new Countdown();

            store.subscribe(new CustomerA("Настя"));
            store.subscribe(new CustomerB("Иван"));
            store.subscribe(new CustomerB("Марья"));
            store.subscribe(new CustomerA("Роман"));

            while (!int.TryParse(Console.ReadLine(), out delay)) { }

            store.notify(delay, "Новый товар!");
            store.notify(delay, "Скидки");
            store.notify(delay, "Конец акции");
            Console.ReadKey();

        }
    }
}
