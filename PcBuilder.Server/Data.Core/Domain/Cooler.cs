using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Data.Core.Domain
{
    public class Cooler: IProduct
    {
        internal string CompatibleSockets { get; set; }

        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public int HeatPipes { get; set; }
        public int Height { get; set; }
        public int Fans { get; set; }
        public int FanSize { get; set; }
        public int FanSpeed { get; set; }
        public double Noise { get; set; }

        [NotMapped]
        public List<string> _compatibleSockets
        {
            get => CompatibleSockets == null ? null : JsonConvert.DeserializeObject<List<string>>(CompatibleSockets);
            set => CompatibleSockets = JsonConvert.SerializeObject(value);
        }

        public static Cooler Create(string title, double price, string imageUrl, string compatibleSockets,
            string type, int heatPipes, int height, int fans, int fanSize, int fanSpeed, double noise)
        {
            var instance = new Cooler
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, compatibleSockets, type, heatPipes, height, fans, fanSize, fanSpeed,
                noise);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string compatibleSockets, string type, int heatPipes, int height, int fans, int fanSize, int fanSpeed, double noise)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            CompatibleSockets = compatibleSockets;
            Type = type;
            HeatPipes = heatPipes;
            Height = height;
            Fans = fans;
            FanSize = fanSize;
            FanSpeed = fanSpeed;
            Noise = noise;
        }
    }
}
