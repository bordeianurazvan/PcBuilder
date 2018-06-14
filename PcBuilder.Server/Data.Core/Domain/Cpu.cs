using System;

namespace Data.Core.Domain
{
    public class Cpu: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Socket { get; set; }
        public string Series { get; set; }
        public string Core { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public double BaseFrequency { get; set; }
        public double TurboFrequency { get; set; }
        public double Cache { get; set; }
        public bool HasStockCooler { get; set; }
        public string TypeOfRam { get; set; }
        public int MaximumRamMemory { get; set; }
        public double RamFrequency { get; set; }

        public static Cpu Create(string title, double price, string imageUrl, string socket, string series, string core,
            int cores, int threads, double baseFrequency, double turboFrequency, double cache, bool hasStockCooler,
            string typeOfRam, int maximumRamMemory, double ramFrequency, string url)
        {
            var instance = new Cpu
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, socket, series, core, cores, threads, baseFrequency, turboFrequency,
                cache, hasStockCooler, typeOfRam, maximumRamMemory, ramFrequency, url);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string socket, string series, string core, int cores,
            int threads, double baseFrequency, double turboFrequency, double cache, bool hasStockCooler, string typeOfRam, int maximumRamMemory, double ramFrequency,string url)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            Socket = socket;
            Series = series;
            Core = core;
            Cores = cores;
            Threads = threads;
            BaseFrequency = baseFrequency;
            TurboFrequency = turboFrequency;
            Cache = cache;
            HasStockCooler = hasStockCooler;
            TypeOfRam = typeOfRam;
            MaximumRamMemory = maximumRamMemory;
            RamFrequency = ramFrequency;
            Url = url;
        }
    }
}
