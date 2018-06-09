using System;

namespace Data.Core.Domain
{
    public class Ram: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public double Frequency { get; set; }
        public string Latency { get; set; }
        public string Standard { get; set; }

        public static Ram Create(string title, double price, string imageUrl, string type, int capacity,
            double frequency, string latency, string standard)
        {
            var instance = new Ram
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, type, capacity, frequency, latency, standard);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string type, int capacity, double frequency, string latency, string standard)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            Type = type;
            Capacity = capacity;
            Frequency = frequency;
            Latency = latency;
            Standard = standard;
        }
    }
}
