
namespace dotnet_backend.Contracts.V1
{
    public class ProductViewModel
    {
        public ProductViewModel(int id, string name, string description, int price, int year, string imageUrl,  int category)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            Price = price;
            Year = year;
            Description = description;
            Category = category;
        }

        public int Id {get; }
        public string Name { get; }
        public string Description { get; }

        public int Price { get; }
        public int Year { get; }
        public string ImageUrl { get; }
        public int Category { get; }    

    }
}