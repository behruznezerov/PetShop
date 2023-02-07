using Petshop.Models;
using System.Linq.Expressions;

PetShop petshop = new();
pisi pishik1 = new("nermin", 16, "girl", 50, 100, 6);
pisi pishik2 = new("necmi", 20, "boy", 90, 6, 8);
CatHouse ev1 = new("kubinka pisik evi");
ev1.AddCat(pishik1);
ev1.AddCat(pishik2);
petshop.catHouses.Add(ev1);

void WrongChoice()
{
    Console.Clear();
    Console.WriteLine("Yanlis Addim");
    Thread.Sleep(2000);
    Console.Clear();
}

labelmain:
Console.Clear();
for (int i = 0; i < petshop.catHouses.Count; i++)
{
    Console.WriteLine(i + 1 + "." + petshop.catHouses[i].name);
}
Console.WriteLine("0.Back");


int choice = Convert.ToInt32(Console.ReadLine());

if (choice < 0 || choice > petshop.catHouses.Count)
{
    WrongChoice();
    goto labelmain;
}
else if (choice == 0)
{

}
else
{
labelcat:
    Console.Clear();
    for (int i = 0; i < petshop.catHouses[choice - 1].cats.Count; i++)
    {
        Console.WriteLine(i + 1 + "." + petshop.catHouses[choice - 1].cats[i].nickname);
    }
    Console.WriteLine($"{petshop.catHouses[choice - 1].cats.Count + 1}.Qiymet\n" + $"{petshop.catHouses[choice - 1].cats.Count + 2}.Yemekler\n" + "0.Geriye\n" + "Pisik Sec\n");
    int choice1 = Convert.ToInt32(Console.ReadLine());
    if (choice1 < 0 || (choice1 > petshop.catHouses[choice - 1].cats.Count && choice1 != petshop.catHouses[choice - 1].cats.Count + 1 && choice1 != petshop.catHouses[choice - 1].cats.Count + 2))
    {
        WrongChoice();
        goto labelcat;
    }
    else if (choice1 == 0)
    {
        goto labelmain;
    }
    else if (choice1 == petshop.catHouses[choice - 1].cats.Count + 1)
    {
    labelallprice:
        Console.Clear();
        double sum = default;
        for (int i = 0; i < petshop.catHouses[choice - 1].cats.Count; i++)
        {
            sum += petshop.catHouses[choice - 1].cats[i].price;
        }
        Console.WriteLine($"Qiymetler : {sum}");
        Console.WriteLine("0.Geriye");
        string choice3 = Console.ReadLine();
        if (choice3 != "0")
        {
            WrongChoice();
            goto labelallprice;
        }
        else
            goto labelcat;
    }
    else if (choice1 == petshop.catHouses[choice - 1].cats.Count + 2)
    {
    labelallmeal:
        Console.Clear();
        double sum = default;
        for (int i = 0; i < petshop.catHouses[choice - 1].cats.Count; i++)
        {
            sum += petshop.catHouses[choice - 1].cats[i].mealQuantity;
        }
        Console.WriteLine($"Yemekler : {sum}");
        string choice3 = Console.ReadLine();
        if (choice3 != "0")
        {
            WrongChoice();
            goto labelallmeal;
        }
        else
            goto labelcat;
    }
    else
    {
    labelcatpersonal:
        Console.Clear();
        Console.WriteLine("1.Pisikle Oyna\n2.Yemek Ver\n0.Geriye\n");
        string choice2 = Console.ReadLine();
        if (choice2 != "1" && choice2 != "2" && choice2 != "0")
        {
            WrongChoice();
            goto labelcatpersonal;
        }
        else if (choice2 == "0")
        {
            goto labelcat;
        }
        else if (choice2 == "1")
        {
            petshop.catHouses[choice - 1].cats[choice1 - 1].Play();
            goto labelcatpersonal;
        }
        else
        {
            petshop.catHouses[choice - 1].cats[choice1 - 1].Eat();
            goto labelcatpersonal;
        }
    }

}
