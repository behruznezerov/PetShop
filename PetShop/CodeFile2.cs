namespace Petshop.Models
{
    public class PetShop
    {
        public List<CatHouse> catHouses = new();
        public int CatHouseCounts { get => catHouses.Count; }
    }
}