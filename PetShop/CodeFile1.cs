using System.Globalization;

namespace Petshop.Models
{
    public class CatHouse
    {
        public List<pisi> cats = new();

        public CatHouse(string name)
        {
            this.name = name;
        }

        public string name { get; set; }
        public void AddCat(pisi cat)
        {
            foreach (pisi cat1 in cats)
            {
                if (cat1.nickname == cat.nickname)
                {
                    Console.Clear();
                    Console.WriteLine("Bele pishik  var");
                    Thread.Sleep(1000);
                    return;
                }
            }

            cats.Add(cat);
        }
        public void RemoveByNickname(pisi cat)
        {
            foreach (pisi cat1 in cats)
            {
                if (cat1.nickname == cat.nickname)
                {
                    cats.Remove(cat1);
                    Console.Clear();
                    Console.WriteLine("Pishik silindi");
                    Thread.Sleep(1000);
                    return;
                }
            }
            Console.WriteLine("Pishik yoxdur");
        }

        public int CatCount { get => cats.Count; }

    }
}