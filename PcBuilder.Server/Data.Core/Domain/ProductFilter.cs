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

                if (!string.IsNullOrEmpty(filterObject["caseId"].ToString()))
                {
                    CaseId = Guid.Parse(filterObject["caseId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["cpuId"].ToString()))
                {
                    CpuId = Guid.Parse(filterObject["cpuId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["coolerId"].ToString()))
                {
                    CoolerId = Guid.Parse(filterObject["coolerId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["motherboardId"].ToString()))
                {
                    MotherboardId = Guid.Parse(filterObject["motherboardId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["ramId"].ToString()))
                {
                    RamId = Guid.Parse(filterObject["ramId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["videocardId"].ToString()))
                {
                    VideoCardId = Guid.Parse(filterObject["videocardId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["storageId"].ToString()))
                {
                    StorageId = Guid.Parse(filterObject["storageId"].ToString());
                }

                if (!string.IsNullOrEmpty(filterObject["powersupplyId"].ToString()))
                {
                    PowerSupplyId = Guid.Parse(filterObject["powersupplyId"].ToString());
                }

            }
        }
    }
}
