using System;

namespace Data.Core.Domain
{
    public class VideoCard: IProduct
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Interface { get; set; }
        public string Resolution { get; set; }
        public string Type { get; set; }
        public int MemorySize { get; set; }
        public int MemoryBus { get; set; }
        public double MemoryFrequency { get; set; }
        public double BaseFrequency { get; set; }
        public double GpuBoostClock { get; set; }
        public int Width { get; set; }

        public static VideoCard Create(string title, double price, string imageUrl, string videoCardInterface,
            string resolution, string type, int memorySize, int memoryBus,
            double memoryFrequency, double baseFrequency, double gpuBoostClock,int width)
        {
            var instance = new VideoCard
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, videoCardInterface, resolution, type, memorySize, memoryBus,
                memoryFrequency, baseFrequency, gpuBoostClock,width);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string videoCardInterface, string resolution, string type, 
            int memorySize, int memoryBus, double memoryFrequency, double baseFrequency, double gpuBoostClock, int width)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            Interface = videoCardInterface;
            Resolution = resolution;
            Type = type;
            MemorySize = memorySize;
            MemoryBus = memoryBus;
            MemoryFrequency = memoryFrequency;
            BaseFrequency = baseFrequency;
            GpuBoostClock = gpuBoostClock;
            Width = width;
        }
    }
}
