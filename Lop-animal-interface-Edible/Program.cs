namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }

            Fruit[] fruit = new Fruit[2];
            fruit[0] = new Apple();
            fruit[1] = new Orange();

            foreach (Fruit fruits in fruit)
            {
                Console.WriteLine(fruits.HowToEat());
            }
        }
    }
}