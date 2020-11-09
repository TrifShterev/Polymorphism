using System;

namespace Animals
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Cat("Pesho", "Whiskas");
            Animals dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
