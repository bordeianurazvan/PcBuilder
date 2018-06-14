using System;
using System.Collections.Generic;
using System.Text;
using Data.Core.Domain;
using Microsoft.EntityFrameworkCore.Internal;

namespace Data.Persistence
{
    public class DataSeeder
    {
        public void Seed(DatabaseContext context)
        {
            if (!context.Cases.Any())
            {
                var case1 = new Case
                {
                    _motherboardFormFactor = new List<string> {"ATX", "mATX", "mIATX"},
                    Title = "Carcasa Deepcool Tesseract BF black",
                    CoolerHeight = 160,
                    Fans = 1,
                    TotalFans = 6,
                    ImageUrl = "https://2.grgs.ro/images/products/1/634551/836749/full/tesseract-bf-black-9cf09a4f48b548f5b5374b800642349e.jpg",
                    NumberOfSlots = 7,
                    Price = 118.22,
                    Type = "MiddleTower",
                    VideoCardWidth = 420,
                    Url = "https://www.pcgarage.ro/carcase/deepcool/tesseract-bf-black/"
                };
                var case2 = new Case
                {
                    _motherboardFormFactor = new List<string> { "ATX", "mATX", "mIATX" },
                    Title = "Carcasa Segotep SG-K8 Black",
                    CoolerHeight = 180,
                    Fans = 1,
                    TotalFans = 6,
                    ImageUrl = "https://5.grgs.ro/images/products/1/1175151/1509310/full/sg-k8-black-e96126214d7b03f844ab330e1115b758.jpg",
                    NumberOfSlots = 7,
                    Price = 269.99,
                    Type = "MiddleTower",
                    VideoCardWidth = 430,
                    Url = "https://www.pcgarage.ro/carcase/segotep/sg-k8-black/"
                };
                var case3 = new Case
                {
                    _motherboardFormFactor = new List<string> { "ATX", "mATX" },
                    Title = "Carcasa Segotep Halo 5 Black",
                    CoolerHeight = 165,
                    Fans = 0,
                    TotalFans = 7,
                    ImageUrl = "https://1.grgs.ro/images/products/1/1469758/1582154/full/halo-5-black-ba466a1679747f9aa63734bb4da33dab.jpg",
                    NumberOfSlots = 7,
                    Price = 101.23,
                    Type = "MiddleTower",
                    VideoCardWidth = 350,
                    Url = "https://www.pcgarage.ro/carcase/segotep/halo-5-black/"
                };

                context.Cases.Add(case1);
                context.Cases.Add(case2);
                context.Cases.Add(case3);
                context.SaveChanges();
            }
            if (!context.Cpus.Any())
            {
                var cpu1 = new Cpu
                {
                    Title = "Intel Kaby Lake, Celeron Dual-Core G3930 2.90GHz box",
                    Price = 162.99,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/959008/1441458/full/kaby-lake-celeron-dual-core-g3930-290ghz-box-f81190764abefa7f81d2e59aff5aa45e.jpg",
                    Socket = "1151",
                    Series = "Celeron Dual-Core",
                    BaseFrequency = 2.9,
                    Cache = 2,
                    Core = "Kaby Lake",
                    Cores = 2,
                    Threads = 2,
                    HasStockCooler = true,
                    TurboFrequency = 2.9,
                    RamFrequency = 2133,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Url = "https://www.pcgarage.ro/procesoare/intel/kaby-lake-celeron-dual-core-g3930-290ghz-box/"
                };
                var cpu2 = new Cpu
                {
                    Title = "AMD Ryzen 3 1200 3.1GHz box",
                    Price = 421.99,
                    ImageUrl =
                        "https://4.grgs.ro/images/products/1/1363661/1513246/full/ryzen-3-1200-31ghz-box-ae4e3d76ff92ca08e199b752537cb517.jpg",
                    Socket = "AM4",
                    Series = "Ryzen 3",
                    BaseFrequency = 3.1,
                    Cache = 8,
                    Core = "Summit Ridge",
                    Cores = 4,
                    Threads = 4,
                    HasStockCooler = true,
                    TurboFrequency = 3.4,
                    RamFrequency = 2400,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Url = "https://www.pcgarage.ro/procesoare/amd/ryzen-3-1200-31ghz-box/"
                };
                var cpu3 = new Cpu
                {
                    Title = "Intel Coffee Lake, Core i3 8100 3.60GHz box",
                    Price = 533.79,
                    ImageUrl =
                        "https://4.grgs.ro/images/products/1/1505170/1580274/full/coffee-lake-core-i3-8100-360ghz-box-35efcb7c044b3247c394a045b4d7926c.jpg",
                    Socket = "1151 V2",
                    Series = "Core i3 8th gen",
                    BaseFrequency = 3.6,
                    Cache = 6,
                    Core = "Coffee Lake",
                    Cores = 4,
                    Threads = 4,
                    HasStockCooler = true,
                    TurboFrequency = 3.6,
                    RamFrequency = 2400,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Url = "https://www.pcgarage.ro/procesoare/intel/coffee-lake-core-i3-8100-360ghz-box/"
                };
                context.Cpus.AddRange(cpu1,cpu2,cpu3);
                context.SaveChanges();
            }
            if (!context.Coolers.Any())
            {
                var cooler1 = new Cooler
                {
                    _compatibleSockets = new List<string>
                    {
                        "775",
                        "1150",
                        "1151",
                        "1155",
                        "1156"
                    },
                    Title = "Cooler CPU Deepcool CK-11509",
                    Price = 11.42,
                    ImageUrl =
                        "https://2.grgs.ro/images/products/1/959008/1192699/full/ck-11509-f8e7eddf9b6194283d19ace9e9a9e192.jpg",
                    Fans = 1,
                    FanSize = 92,
                    FanSpeed = "2200 RPM",
                    HeatPipes = 1,
                    Height = 56,
                    Noise = "26.1 dBA",
                    Type = "Air",
                    Url = "https://www.pcgarage.ro/coolere/deepcool/ck-11509-1/"
                };

                var cooler2 = new Cooler
                {
                    _compatibleSockets = new List<string>
                    {
                        "775",
                        "1150",
                        "1151",
                        "1155",
                        "1156","AM2","AM3","FM1"
                    },
                    Title = "Cooler CPU Deepcool GAMMAXX 200T",
                    Price = 46.80,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/3/1137703/full/gammaxx-200t-08df8365e72f5284e08f1a6f8c499eaa.jpg",
                    Fans = 1,
                    FanSize = 120,
                    FanSpeed = "900 - 1600 RPM",
                    HeatPipes = 1,
                    Height = 131,
                    Noise = "17.8 - 26.1 dBA",
                    Type = "Air",
                    Url = "https://www.pcgarage.ro/coolere/deepcool/gammaxx-200t/"
                };
                var cooler3 = new Cooler
                {
                    _compatibleSockets = new List<string>
                    {
                        "775",
                        "1150",
                        "1151",
                        "1155",
                        "1156","2011",
                    },
                    Title = "Cooler CPU ID-Cooling ICEKIMO 120 Blue",
                    Price = 243.26,
                    ImageUrl =
                        "https://4.grgs.ro/images/products/1/959008/1429930/full/icekimo-120-blue-db1d26a4483dfd83864b524218eb2343.jpg",
                    Fans = 1,
                    FanSize = 120,
                    FanSpeed = "600 - 1600 RPM",
                    HeatPipes = 1,
                    Height = 56,
                    Noise = "16.2 - 30.5 dBA",
                    Type = "Water",
                    Url = "https://www.pcgarage.ro/coolere/id-cooling/icekimo-120-blue/"
                };
                context.AddRange(cooler1,cooler2,cooler3);
                context.SaveChanges();
            }
            if (!context.Motherboards.Any())
            {
                var motherboard1 = new Motherboard
                {
                    Title = "ASRock A320M-DGS",
                    Price = 224.12,
                    ImageUrl =
                        "https://2.grgs.ro/images/products/1/1469770/1506238/full/a320m-dgs-97a358a6820b3c5bd713b94babdfab48.jpg",
                    FormFactor = "mATX",
                    Socket = "AM4",
                    GraphicInterface = "PCI Express x16 3.0",
                    Sata = 4,
                    M2 = 1,
                    RamSlots = 2,
                    RamFrequency = 3200,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 32,
                    Network = "10/100/1000 Mbps",
                    Url = "https://www.pcgarage.ro/placi-de-baza/asrock/a320m-dgs/"
                };
                var motherboard2 = new Motherboard
                {
                    Title = "ASUS H110M-K",
                    Price = 229.71,
                    ImageUrl =
                        "https://4.grgs.ro/images/products/1/1088099/1145358/full/h110m-k-37d2ce4102228154aff209d5cb306595.jpg",
                    FormFactor = "mATX",
                    Socket = "1151",
                    GraphicInterface = "PCI Express x16 3.0",
                    Sata = 4,
                    M2 = 0,
                    RamSlots = 2,
                    RamFrequency = 2133,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 32,
                    Network = "10/100/1000 Mbps",
                    Url = "https://www.pcgarage.ro/placi-de-baza/asus/h110m-k/"
                };
                var motherboard3 = new Motherboard
                {
                    Title = "MSI H310M PRO-VD",
                    Price = 285.29,
                    ImageUrl =
                        "https://1.grgs.ro/images/products/1/1664836/1675040/full/h310m-pro-vd-4f8bf71c8343100814de80c6be07487c.jpg",
                    FormFactor = "mATX",
                    Socket = "1151 v2",
                    GraphicInterface = "PCI Express x16 3.0",
                    Sata = 4,
                    M2 = 0,
                    RamSlots = 2,
                    RamFrequency = 2666,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 32,
                    Network = "10/100/1000 Mbps",
                    Url = "https://www.pcgarage.ro/placi-de-baza/msi/h310m-pro-vd/"
                };
                context.Motherboards.AddRange(motherboard1,motherboard2,motherboard3);
                context.SaveChanges();
            }
            if (!context.Rams.Any())
            {
                var ram1 = new Ram
                {
                    Title = "Patriot Signature 8GB DDR4 2400MHz CL17 1.2V Dual Channel Kit",
                    Price = 443.74,
                    ImageUrl = "https://4.grgs.ro/images/products/1/922/1644880/full/signature-8gb-ddr4-2400mhz-cl17-12v-dual-channel-kit-5c3e89801c913cadf8371488fef881f8.jpeg",
                    Capacity = 8,
                    Frequency = 2400,
                    Latency = "17 CL",
                    Standard = "PC4-19200",
                    Type = "DDR4",
                    Url = "https://www.pcgarage.ro/memorii/patriot/signature-8gb-ddr4-2400mhz-cl17-12v-dual-channel-kit/"
                };
                var ram2 = new Ram
                {
                    Title = "Patriot Signature Line Heatspreader 8GB DDR3 1333MHz CL9 Dual Channel Kit 1.5v",
                    Price = 313.70,
                    ImageUrl = "https://4.grgs.ro/images/products/1/735074/806485/full/signature-line-heatspreader-8gb-ddr3-1333mhz-cl9-dual-channel-kit-15v-f139779e54e7cd5c4da771606c05acf6.jpg",
                    Capacity = 8,
                    Frequency = 1333,
                    Latency = "9 CL",
                    Standard = "PC3-10600",
                    Type = "DDR3",
                    Url = "https://www.pcgarage.ro/memorii/patriot/signature-line-heatspreader-8gb-ddr3-1333mhz-cl9-dual-channel-kit-15v/"
                };
                var ram3 = new Ram
                {
                    Title = "Corsair Dominator Platinum 8GB DDR4 3200MHz CL16 Dual Channel Kit",
                    Price = 727.11,
                    ImageUrl = "https://5.grgs.ro/images/products/1/1263508/1509726/full/dominator-platinum-8gb-ddr4-3200mhz-cl16-dual-channel-kit-69f8a4a5864c59f174acd70a00069ff5.jpg",
                    Capacity = 8,
                    Frequency = 3200,
                    Latency = "16 CL",
                    Standard = "PC4-25600",
                    Type = "DDR4",
                    Url = "https://www.pcgarage.ro/memorii/corsair/dominator-platinum-8gb-ddr4-3200mhz-cl16-dual-channel-kit/"
                };
                context.Rams.AddRange(ram1,ram2,ram3);
                context.SaveChanges();
            }
            if (!context.VideoCards.Any())
            {
                var videocard1 = new VideoCard
                {
                    Title = "Sapphire Radeon RX 560 PULSE 2GB DDR5 128-bit Lite",
                    Price = 666.54,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1420862/1598530/full/radeon-rx-560-pulse-2gb-ddr5-128-bit-b3afe28abc822bd03cd620b3e354c35a.jpg",
                    Interface = "PCI Express x8 3.0",
                    BaseFrequency = 1226,
                    GpuBoostClock = 1226,
                    MemoryFrequency = 6000,
                    MemorySize = 2,
                    MemoryBus = 128,
                    Resolution = "3840x2160 pixels",
                    Type = "GDDR5",
                    Width = 210,
                    Url = "https://www.pcgarage.ro/placi-video/sapphire/radeon-rx-560-pulse-2gb-ddr5-128-bit-lite/"
                };
                var videocard2 = new VideoCard
                {
                    Title = "MSI GeForce GTX 1050 Ti GAMING X 4GB DDR5 128-bit",
                    Price = 1013.23,
                    ImageUrl =
                        "https://2.grgs.ro/images/products/1/1416562/1422550/full/geforce-gtx-1050-ti-gaming-x-4gb-ddr5-128-bit-72e7b5b7bc239016033069836ea2c98e.jpg",
                    Interface = "PCI Express x16 3.0",
                    BaseFrequency = 1379,
                    GpuBoostClock = 1493,
                    MemoryFrequency = 7008,
                    MemorySize = 4,
                    MemoryBus = 128,
                    Resolution = "7680x4320 pixels",
                    Type = "GDDR5",
                    Width = 229,
                    Url = "https://www.pcgarage.ro/placi-video/msi/geforce-gtx-1050-ti-gaming-x-4gb-ddr5-128-bit/"
                };
                var videocard3 = new VideoCard
                {
                    Title = "GIGABYTE GeForce GTX 1060 G1 GAMING 3GB DDR5 192-bit",
                    Price = 1401.18,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/1355434/1402571/full/geforce-gtx-1060-g1-gaming-6gb-ddr5-192-bit-03a069572d97f70319d04dbc2d2e1532.jpg",
                    Interface = "PCI Express x16 3.0",
                    BaseFrequency = 1594,
                    GpuBoostClock = 1847,
                    MemoryFrequency = 8008,
                    MemorySize = 3,
                    MemoryBus = 192,
                    Resolution = "7680x4320 pixeli",
                    Type = "GDDR5",
                    Width = 278,
                    Url = "https://www.pcgarage.ro/placi-video/gigabyte/geforce-gtx-1060-g1-gaming-3gb-ddr5-192-bit/"
                };
                context.VideoCards.AddRange(videocard1,videocard2,videocard3);
                context.SaveChanges();
            }
            if (!context.Storages.Any())
            {
                var storage1 = new Storage
                {
                    Title = "SSD Kingston A400 120GB SATA-III 2.5 inch",
                    Price = 145.99,
                    ImageUrl = "https://1.grgs.ro/images/products/1/1427502/1487666/full/a400-120gb-sata-iii-25-inch-ace5ac38fb969418fdf46f467226e385.jpg",
                    Capacity = "120 GB",
                    FormFactor = "2.5 inch",
                    Interface = "SATA-III",
                    ReadSpeed = "500 MB/s",
                    WriteSpeed = "320 MB/s",
                    Rpm = "0",
                    Url = "https://www.pcgarage.ro/ssd/kingston/a400-120gb-sata-iii-25-inch/"
                };
                var storage2 = new Storage
                {
                    Title = "SSD WD NEW Green 120GB SATA-III M.2 2280",
                    Price = 156.68,
                    ImageUrl = "https://5.grgs.ro/images/products/1/1094679/1619870/full/green-120gb-sata-iii-m2-2280-97217b3c0f7074000c5a992caa221ed6.jpg",
                    Capacity = "120 GB",
                    FormFactor = "M.2",
                    Interface = "SATA-III",
                    ReadSpeed = "540 MB/s",
                    WriteSpeed = "430 MB/s",
                    Rpm = "0",
                    Url = "https://www.pcgarage.ro/ssd/western-digital/new-green-120gb-sata-iii-m2-2280/"
                };
                var storage3 = new Storage
                {
                    Title = "Hard disk WD Blue 1TB SATA-III 7200 RPM 64MB",
                    Price = 209.99,
                    ImageUrl = "https://1.grgs.ro/images/products/1/5/376435/full/blue-1tb-sata-iii-7200-rpm-64mb-c80ce3c15c30d4fb80c1af17bd3757e5.jpg",
                    Capacity = "1 TB",
                    FormFactor = "3.5 inch",
                    Interface = "SATA-III",
                    ReadSpeed = "",
                    WriteSpeed = "",
                    Rpm = "7200 RPM",
                    Url = "https://www.pcgarage.ro/hard-disk-uri/western-digital/1tb-sata-iii-7200-rpm-64mb-caviar-blue/"
                };
                context.Storages.AddRange(storage1,storage2,storage3);
                context.SaveChanges();
            }
            if (!context.PowerSupplies.Any())
            {
                var powersupply1 = new PowerSupply
                {
                    Title = "Sursa Inter-Tech SL-500 PLUS 500W",
                    Price = 119.56,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/986897/1166167/full/sl-500-plus-500w-397fbe5517714543cdba0349681d4746.jpg",
                    Certificate = "-",
                    Cooler = "1x 120 mm",
                    Efficiency = "90.2 %",
                    IsModular = false,
                    Pfc = "Active",
                    Power = "500 W"
                };
                var powersupply2 = new PowerSupply
                {
                    Title = "Sursa Corsair VS Series VS550, 80+ , 550W",
                    Price = 213.44,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1630882/1633630/full/vs-series-vs550-80-plus-550w-eebbc36465833303550c5b2e5ab47955.jpg",
                    Certificate = "80+",
                    Cooler = "1x 120 mm",
                    Efficiency = "85 %",
                    IsModular = false,
                    Pfc = "Active",
                    Power = "550 W"
                };
                var powersupply3 = new PowerSupply
                {
                    Title = "Sursa Seasonic M12II-620 EVO Edition Bronze 620W",
                    Price = 324.99,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/1/796171/full/m12ii-620-evo-edition-bronze-620w-483c4147ce1f871ef3828319b7535f0d.jpg",
                    Certificate = "80+ Bronze",
                    Cooler = "1x 120 mm",
                    Efficiency = "87 %",
                    IsModular = true,
                    Pfc = "Active",
                    Power = "620 W"
                };
                context.PowerSupplies.AddRange(powersupply1,powersupply2,powersupply3);
                context.SaveChanges();
            }

        }
    }
}
