using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Core.Domain
{
    public class Case: IProduct
    {
        internal string MotherBoardFormFactor { get; set; }

        public Guid Id { get; private set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public int NumberOfSlots { get; set; }
        public int CoolerHeight { get; set; }
        public int VideoCardWidth { get; set; }
        public int Fans { get; set; }
        public int TotalFans { get; set; }


        [NotMapped]
        public List<string> _motherboardFormFactor
        {
            get => MotherBoardFormFactor == null ? null : JsonConvert.DeserializeObject<List<string>>(MotherBoardFormFactor);
            set => MotherBoardFormFactor = JsonConvert.SerializeObject(value);
        }

        public static Case Create(string title, double price, string imageUrl, string type,
            string motherboardFormFactor, int numberOfSlots, int coolerHeight, int videoCardWidth, int fans,
            int totalFans,string url)
        {
            var instance = new Case
            {
                Id = new Guid()
            };
            instance.Update(title, price, imageUrl, type, motherboardFormFactor, numberOfSlots, coolerHeight,
                videoCardWidth, fans, totalFans,url);
            return instance;
        }

        private void Update(string title, double price, string imageUrl, string type, string motherboardFormFactor, int numberOfSlots, int coolerHeight, int videoCardWidth, int fans, int totalFans, string url)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            Type = type;
            MotherBoardFormFactor = motherboardFormFactor;
            NumberOfSlots = numberOfSlots;
            CoolerHeight = coolerHeight;
            VideoCardWidth = videoCardWidth;
            Fans = fans;
            TotalFans = totalFans;
            Url = url;
        }
    }
}
