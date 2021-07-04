namespace dotnet_backend
{
    public class Product
    {
        public Product(
            string name,
            int id,
            string description,
            int price,
            string imageUrl,
            int year,
            string[] platform,
            object category
        )
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            Year = year;
            Category = category;
            Platform = platform;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public object Category { get; set; }
        public string[] Platform { get; set; }
    }
}