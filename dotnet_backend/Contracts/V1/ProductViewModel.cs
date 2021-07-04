
namespace dotnet_backend.Contracts.V1
{
    public class ProductViewModel
    {
        public ProductViewModel(int id, string name, string description, int price, int year, string[] platform, object category, string imageUrl)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            Price = price;
            Year = year;
            Description = description;
            Category = category;
            Platform = platform;
        }

        public string Name { get; }
        public int Price { get; }
        public int Year { get; }
        public string Description { get; }
        public string[] Platform { get; }
        public object Category { get; }
        public int Id { get; }
        public string ImageUrl { get; }


    }
}