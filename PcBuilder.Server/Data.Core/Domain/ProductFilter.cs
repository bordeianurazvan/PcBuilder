using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Data.Core.Domain
{
    public class ProductFilter
    {
        public Guid CaseId { get; set; }
        public Guid CpuId { get; set; }
        public Guid CoolerId { get; set; }
        public Guid MotherboardId { get; set; }
        public Guid RamId { get; set; }
        public Guid VideoCardId { get; set; }
        public Guid StorageId { get; set; }
        public Guid PowerSupplyId { get; set; }

        public ProductFilter(string filter)
        {
            var filterObject = new JObject();
            if (filter != null)
            {
                filterObject = JObject.Parse(filter);

                CaseId = (Guid) filterObject["caseId"];
                CpuId = (Guid) filterObject["cpuId"];
                CoolerId = (Guid) filterObject["coolerId"];
                MotherboardId = (Guid) filterObject["motherboardId"];
                RamId = (Guid) filterObject["ramId"];
                VideoCardId = (Guid) filterObject["videoCardId"];
                StorageId = (Guid) filterObject["storageId"];
                PowerSupplyId = (Guid) filterObject["powerSupplyId"];
            }
        }
    }
}
