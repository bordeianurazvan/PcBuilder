using System;

namespace Data.Core.Domain
{
    public class Motherboard: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string FormFactor { get; set; }
        public string Socket { get; set; }
        public int Sata { get; set; }
        public int M2 { get; set; }
        public string Network { get; set; }
        public string TypeOfRam { get; set; }
        public double MaximumRamMemory { get; set; }
        public double RamFrequency { get; set; }
        public int RamSlots { get; set; }
        public string GraphicInterface { get; set; }

        public static Motherboard Create(string title, double price, string imageUrl, string formFactor, string socket,
            int sata, int m2, string network, string typeOfRam, double maximumRamMemory,
            double ramFrequency, int ramSlots, string graphicInterface)
        {
            var instance = new Motherboard
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, formFactor, socket, sata, m2, network, typeOfRam, maximumRamMemory,
                ramFrequency, ramSlots, graphicInterface);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string formFactor, string socket, int sata, int m2, string network, 
            string typeOfRam, double maximumRamMemory, double ramFrequency, int ramSlots, string graphicInterface)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            FormFactor = formFactor;
            Socket = socket;
            Sata = sata;
            M2 = m2;
            Network = network;
            TypeOfRam = typeOfRam;
            MaximumRamMemory = maximumRamMemory;
            RamFrequency = ramFrequency;
            RamSlots = ramSlots;
            GraphicInterface = graphicInterface;
        }
    }
}
