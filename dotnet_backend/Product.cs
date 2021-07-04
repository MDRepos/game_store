namespace dotnet_backend
{
    public class Product
    {
        public Product(
            int id,
            string name,
            string description,
            int price,
            int year,
            string imageUrl,
            int category,
            string[] platform
        )
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Year = year;
            ImageUrl = imageUrl;
            Category = category;
            Platform = platform;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public int Category { get; set; }
        public string[] Platform { get; set; }
    }
}