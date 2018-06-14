using System;

namespace Data.Core.Domain
{
    public class Storage: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string FormFactor { get; set; }
        public string Interface { get; set; }
        public string Capacity { get; set; }
        public string WriteSpeed { get; set; }
        public string ReadSpeed { get; set; }
        public string Rpm { get; set; }

        public static Storage Create(string title, double price, string imageUrl, string formFactor,
            string storageInterface, string capacity, string writeSpeed, string readSpeed, string rpm, string url)
        {
            var instance = new Storage
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, formFactor, storageInterface, capacity, writeSpeed, readSpeed, rpm, url);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string formFactor, string storageInterface, string capacity, string writeSpeed, string readSpeed, string rpm, string url)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            FormFactor = formFactor;
            Interface = storageInterface;
            Capacity = capacity;
            WriteSpeed = writeSpeed;
            ReadSpeed = readSpeed;
            Rpm = rpm;
            Url = url;
        }
    }
}
