
using System;
namespace Project
{
    public class Pet
    {
        private string color = "";
        private int age = 0;

        public Pet(string Color, int Age)
        {
            color = Color;
            age = Age;
        }

        public string Color { get { return color; } }
        public int Age { get { return age; } }


        public virtual void makeasound()
        {
            Console.WriteLine("hmm");
        }
    }

    public class Cat : Pet
    {
        string hairstyle = "";

        public Cat(string Color , int Age,string Hairstyle) : base(Color,Age)
        {
            hairstyle = Hairstyle;
        }

        public string Hairstyle { get { return hairstyle; } }

        public override void makeasound()
        {
            Console.WriteLine("meow");
        }
    }

    public class Dog : Pet
    {
        int money = 0;
        public Dog(string Color,int Age,int Money) : base(Color,Age)
        {
            money = Money;
        }
        public int Money { get { return money; } }

        public override void makeasound()
        {
            Console.WriteLine("rich dog noises");
        }
    }

    class mainclasi
    {

        public static void Main(string[] args)
        {
            Pet pet1 = new Cat("yellow", 2, "cool hairstyle");
            Pet pet2 = new Dog("green", 3, 300);
            pet1.makeasound();
            pet2.makeasound();
        }
    }
}