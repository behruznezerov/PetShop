using System.ComponentModel.DataAnnotations;

namespace Petshop.Models
{
    public class pisi
    {
        public pisi(string nickname, double age, string gender, double energy, double price, double mealQuantity)
        {
            this.nickname = nickname;
            this.age = age;
            this.gender = gender;
            this.energy = energy;
            this.price = price;
            this.mealQuantity = mealQuantity;
        }

        public string nickname { get; set; }

        public double age { get; set; }

        public string gender { get; set; }

        public double energy { get; set; }

        public double price { get; set; }

        public double mealQuantity { get; set; }

        public void Eat()
        {
            if (energy == 100)
            {
                Console.Clear();
                Console.WriteLine("Pishik toxdur");
                Thread.Sleep(1000);
                return;
            }
            age += 0.1;
            price += 0.2;
            energy += 10;
            Console.Write("Pishik yeyir");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Pishik yemeyini bitirdi");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public void Sleep()
        {
            Console.Write("Pishik getdi yatmaga");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            energy = 100;
        }

        public void Play()
        {
            if (energy == 0)
            {
                Sleep();
                return;
            }
            Console.Write("Pishik oynayir");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            energy -= 10;
            Console.Clear();
            Console.WriteLine("Pishik Durdu");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}