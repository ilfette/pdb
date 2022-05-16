using System;

    public abstract class Customer
    {
        public readonly string name;
        public readonly string reaction;

        public Customer(string name)
        {
            this.name = name;
        }
        public abstract string display(string message);
        public void print(string reaction) {
        Console.WriteLine(name+": "+ reaction);
        }

    }

    public class CustomerA : Customer
    {
        public CustomerA(string name) : base(name)
        {
        }

        public override string display(string message) {
            {
                string reaction="";
                if (message.Equals("Новый товар!"))
                {
                    reaction = "Надо посмотреть";                    
                }
                    else if (message.Equals("Скидки"))
                {
                    reaction = "Наконец-то";               
                }                   
                    else
                {
                    reaction = " Не очень то и надо было";
                }
            print(reaction);
            return reaction;
            }
        }
            

    }
    public class CustomerB : Customer
    {
        public CustomerB(string name) : base(name)
        {
        }

        public override string display(string message)
        {          
            string reaction = "";
            if (message.Equals("Новый товар!"))
            {
                reaction = "Опять что-то";
            }
            else if (message.Equals("Скидки"))
            {
                reaction = "Надо бы отписаться...";
            }
            else
            {
                reaction = " Да, пора отписаться.";
            }
        print(reaction);
        return reaction;
    }
    }