using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Core.Domain
{
    public class Post
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid CaseId { get; set; }
        public Guid CpuId { get; set; }
        public Guid? CoolerId { get; set; }
        public Guid MotherboardId { get; set; }
        public Guid RamId { get; set; }
        public Guid VideoCardId { get; set; }
        public Guid StorageId { get; set; }
        public Guid PowerSupplyId { get; set; }

    }
}
