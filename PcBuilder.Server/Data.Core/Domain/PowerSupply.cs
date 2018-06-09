using System;

namespace Data.Core.Domain
{
    public class PowerSupply: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Power { get; set; }
        public int Efficiency { get; set; }
        public string Certificate { get; set; }
        public bool IsModular { get; set; }
        public string Cooler { get; set; }
        public string Pfc { get; set; }

        public static PowerSupply Create(string title, double price, string imageUrl, int power, int efficiency,
            string certificate, bool isModular, string cooler, string pfc)
        {
            var instance = new PowerSupply
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, power, efficiency, certificate, isModular, cooler, pfc);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, int power, int efficiency, string certificate, bool isModular, string cooler, string pfc)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            Power = power;
            Efficiency = efficiency;
            Certificate = certificate;
            IsModular = isModular;
            Cooler = cooler;
            Pfc = pfc;
        }
    }
}
