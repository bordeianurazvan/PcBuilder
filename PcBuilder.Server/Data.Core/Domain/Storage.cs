using System;

namespace Data.Core.Domain
{
    public class Storage: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string FormFactor { get; set; }
        public string Interface { get; set; }
        public int Capacity { get; set; }
        public double WriteSpeed { get; set; }
        public double ReadSpeed { get; set; }
        public double Rpm { get; set; }

        public static Storage Create(string title, double price, string imageUrl, string formFactor,
            string storageInterface, int capacity, double writeSpeed, double readSpeed, double rpm)
        {
            var instance = new Storage
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, formFactor, storageInterface, capacity, writeSpeed, readSpeed, rpm);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string formFactor, string storageInterface, int capacity, double writeSpeed, double readSpeed, double rpm)
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
        }
    }
}
