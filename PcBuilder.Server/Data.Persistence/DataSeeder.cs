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
                var case4 = new Case
                {
                    _motherboardFormFactor = new List<string> { "ATX", "mATX" },
                    Title = "Carcasa Zalman Z3 Plus",
                    CoolerHeight = 160,
                    Fans = 4,
                    TotalFans = 5,
                    ImageUrl = "https://4.grgs.ro/images/products/1/1/738746/full/z3-plus-81152446c4614a5058ebede7087e7993.jpg",
                    NumberOfSlots = 7,
                    Price = 192.78,
                    Type = "MiddleTower",
                    VideoCardWidth = 360,
                    Url = "https://www.pcgarage.ro/carcase/zalman/z3-plus/"
                };
                var case5 = new Case
                {
                    _motherboardFormFactor = new List<string> { "ATX", "mATX", "mITX" },
                    Title = "Carcasa Redragon Sidewipe Black",
                    CoolerHeight = 160,
                    Fans = 4,
                    TotalFans = 7,
                    ImageUrl = "https://4.grgs.ro/images/products/1/1630882/1632942/full/sidewipe-black-688744b8d79556ffef6047075a6c21e1.jpg",
                    NumberOfSlots = 7,
                    Price = 259.99,
                    Type = "MiddleTower",
                    VideoCardWidth = 350,
                    Url = "https://www.pcgarage.ro/carcase/redragon/sidewipe-black/"
                };
                var case6 = new Case
                {
                    _motherboardFormFactor = new List<string> { "ATX", "mATX", "mITX" },
                    Title = "Carcasa Floston RED FIRE",
                    CoolerHeight = 165,
                    Fans = 2,
                    TotalFans = 7,
                    ImageUrl = "https://1.grgs.ro/images/products/1/1169071/1502262/full/red-fire-d3db42cd158464ce2c0f5df2c43b254c.jpg  ",
                    NumberOfSlots = 7,
                    Price = 110.63,
                    Type = "MiddleTower",
                    VideoCardWidth = 350,
                    Url = "https://www.pcgarage.ro/carcase/floston/red-fire/"
                };

                context.Cases.AddRange(case1,case2,case3,case4,case5,case6);
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
                var cpu4 = new Cpu
                {
                    Title = "Intel Kaby Lake, Core i7 7700K 4.20GHz box",
                    Price = 1399.99,
                    ImageUrl =
                        "https://4.grgs.ro/images/products/1/1427502/1437442/full/kaby-lake-core-i7-7700k-420ghz-box-db92e85515a9b91c41fe2d051410b229.jpg",
                    Socket = "1151",
                    Series = "Core i7 7th gen",
                    BaseFrequency = 4.2,
                    Cache = 8,
                    Core = "Kaby Lake",
                    Cores = 4,
                    Threads = 8,
                    HasStockCooler = false,
                    TurboFrequency = 4.5,
                    RamFrequency = 2400,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Url = "https://www.pcgarage.ro/procesoare/intel/kaby-lake-core-i7-7700k-420ghz-box/"
                };
                var cpu5 = new Cpu
                {
                    Title = "AMD Ryzen 7 2700X 3.7GHz box",
                    Price = 1604.99,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1416562/1675620/full/ryzen-7-2700x-37ghz-box-40321da45d1494ae3de24d95f96624b3.jpg",
                    Socket = "AM4",
                    Series = "Ryzen 7",
                    BaseFrequency = 3.7,
                    Cache = 16,
                    Core = "Pinnacle Ridge",
                    Cores = 8,
                    Threads = 16,
                    HasStockCooler = true,
                    TurboFrequency = 4.3,
                    RamFrequency = 2933,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Url = "https://www.pcgarage.ro/procesoare/amd/ryzen-7-2700x-37ghz-box/"
                };
                var cpu6 = new Cpu
                {
                    Title = "Intel Kaby Lake, Core i3 7100 3.9GHz box",
                    Price = 502.40,
                    ImageUrl =
                        "https://2.grgs.ro/images/products/1/1109408/1440114/full/intel-kaby-lake-core-i3-7100-39-ghz-box-21bf9b82937b94d75b8f20872eb5453f.jpg",
                    Socket = "1151",
                    Series = "Core i3 7th gen",
                    BaseFrequency = 3.9,
                    Cache = 3,
                    Core = "Kaby Lake",
                    Cores = 2,
                    Threads = 4,
                    HasStockCooler = true,
                    TurboFrequency = 3.9,
                    RamFrequency = 2400,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Url = "https://www.pcgarage.ro/procesoare/intel/kaby-lake-core-i3-7100-39ghz-box/"
                };
                context.Cpus.AddRange(cpu1,cpu2,cpu3,cpu4,cpu5,cpu6);
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
                        "1156",
                        "1151 V2"
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
                        "1156","AM2","AM3","FM1","AM4"
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
                        "1156","2011"
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
                var cooler4 = new Cooler
                {
                    _compatibleSockets = new List<string>
                    {
                        "775",
                        "1150",
                        "1151",
                        "1155",
                        "1156","2011","AM4"
                    },
                    Title = "Cooler CPU Deepcool GAMMAXX 300",
                    Price = 80.07,
                    ImageUrl =
                        "https://2.grgs.ro/images/products/1/4/369867/full/gammaxx300-a3dc52ee426b5980936d02dbb2a88749.jpg",
                    Fans = 1,
                    FanSize = 120,
                    FanSpeed = "900 - 1600 rpm",
                    HeatPipes = 3,
                    Height = 136,
                    Noise = "17.8 - 21 dB(A)",
                    Type = "Air",
                    Url = "https://www.pcgarage.ro/coolere/deepcool/gammaxx300/"
                };
                var cooler5 = new Cooler
                {
                    _compatibleSockets = new List<string>
                    {
                        "775",
                        "1150",
                        "1151",
                        "1155",
                        "1156","2011","AM4"
                    },
                    Title = "Cooler CPU ID-Cooling SE-213v2",
                    Price = 72.77,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1088254/1136948/full/se-213v2-c268f602dfef68c9e200d8b607508eb8.jpg",
                    Fans = 1,
                    FanSize = 120,
                    FanSpeed = "800 - 1600 RPM",
                    HeatPipes = 3,
                    Height = 140,
                    Noise = "16 - 20.2 dBA",
                    Type = "Air",
                    Url = "https://www.pcgarage.ro/coolere/id-cooling/se-213v2/"
                };
                var cooler6 = new Cooler
                {
                    _compatibleSockets = new List<string>
                    {
                        "775",
                        "1150",
                        "1151",
                        "1155",
                        "1156","2011"
                    },
                    Title = "Cooler CPU Deepcool Captain 120 EX",
                    Price = 243.26,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/1052635/1386829/full/captain-120-ex-0c1d28bdb97b86f9f3eac11c6d0e7af6.jpg",
                    Fans = 1,
                    FanSize = 120,
                    FanSpeed = "500 - 1800 RPM",
                    HeatPipes = 1,
                    Height = 56,
                    Noise = "17.6 - 31.3 dBA",
                    Type = "Water",
                    Url = "https://www.pcgarage.ro/coolere/deepcool/captain-120-ex/"
                };
                context.AddRange(cooler1,cooler2,cooler3,cooler4,cooler5,cooler6);
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
                var motherboard4 = new Motherboard
                {
                    Title = "GIGABYTE GA-B250M-D3H",
                    Price = 365.49,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1088254/1438642/full/ga-b250m-d3h-eb62a3e51ed0b7073e16ec84a3c20fcc.jpg",
                    FormFactor = "mATX",
                    Socket = "1151",
                    GraphicInterface = "PCI Express x16 3.0",
                    Sata = 6,
                    M2 = 1,
                    RamSlots = 4,
                    RamFrequency = 2400,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Network = "10/100/1000 Mbps",
                    Url = "https://www.pcgarage.ro/placi-de-baza/gigabyte/b250m-d3h/"
                };
                var motherboard5 = new Motherboard
                {
                    Title = "MSI B350 PC MATE",
                    Price = 404.22,
                    ImageUrl =
                        "https://2.grgs.ro/images/products/1/1358815/1474654/full/b350-pc-mate-9622702829f1cb1a4292bccf809fe445.jpg",
                    FormFactor = "mATX",
                    Socket = "AM4",
                    GraphicInterface = "PCI Express x16 3.0",
                    Sata = 4,
                    M2 = 1,
                    RamSlots = 4,
                    RamFrequency = 3200,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Network = "10/100/1000 Mbps",
                    Url = "https://www.pcgarage.ro/placi-de-baza/msi/b350-pc-mate/"
                };
                var motherboard6 = new Motherboard
                {
                    Title = "GIGABYTE AORUS Z370 Gaming K3",
                    Price = 653.06,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1409094/1541334/full/z370-aorus-gaming-k3-5473ecf4d47af90ae1b88abd190d21ab.jpg",
                    FormFactor = "ATX",
                    Socket = "1151 v2",
                    GraphicInterface = "PCI Express x16 3.0",
                    Sata = 6,
                    M2 = 2,
                    RamSlots = 4,
                    RamFrequency = 4000,
                    TypeOfRam = "DDR4",
                    MaximumRamMemory = 64,
                    Network = "10/100/1000 Mbps",
                    Url = "https://www.pcgarage.ro/placi-de-baza/gigabyte/aorus-z370-gaming-k3/"
                };
                context.Motherboards.AddRange(motherboard1,motherboard2,motherboard3,motherboard4,motherboard5,motherboard6);
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
                var ram4 = new Ram
                {
                    Title = "HyperX Fury Red 8GB DDR4 2400MHz CL15 1.2v",
                    Price = 434.15,
                    ImageUrl = "https://2.grgs.ro/images/products/1/812812/1479858/full/fury-red-8gb-ddr4-2400mhz-cl15-12v-bc58ca971de5d9a290d1c51c662a9f7a.jpg",
                    Capacity = 8,
                    Frequency = 2400,
                    Latency = "15 CL",
                    Standard = "PC4-19200",
                    Type = "DDR4",
                    Url = "https://www.pcgarage.ro/memorii/hyperx/fury-red-8gb-ddr4-2400mhz-cl15-12v/"
                };
                var ram5 = new Ram
                {
                    Title = "Corsair Vengeance LPX Black 16GB DDR4 2133MHz CL13 Quad Channel Kit",
                    Price = 1032.41,
                    ImageUrl 
                    = "https://5.grgs.ro/images/products/1/3/981307/full/vengeance-lpx-black-16gb-ddr4-2400mhz-cl14-quad-channel-kit-2e21bbdaac59e5c55e29758c59e38566.jpg",
                    Capacity = 16,
                    Frequency = 2133,
                    Latency = "13 CL",
                    Standard = "PC4-17000",
                    Type = "DDR4",
                    Url = "https://www.pcgarage.ro/memorii/corsair/vengeance-lpx-black-16gb-ddr4-2133mhz-cl13-quad-channel-kit/"
                };
                var ram6 = new Ram
                {
                    Title = "Corsair Dominator Platinum 16GB DDR4 2666MHz CL15 Quad Channel Kit",
                    Price = 1296.34,
                    ImageUrl =
                    "https://5.grgs.ro/images/products/1/2/882902/full/dominator-platinum-16gb-ddr4-2660mhz-cl15-quad-channel-kit-7a5c41c6cf5734dff94f7eb6f7d17f52.jpg",
                    Capacity = 16,
                    Frequency = 2666,
                    Latency = "15 CL",
                    Standard = "PC4-21300",
                    Type = "DDR4",
                    Url = "https://www.pcgarage.ro/memorii/corsair/dominator-platinum-16gb-ddr4-2660mhz-cl15-quad-channel-kit/"
                };
                context.Rams.AddRange(ram1,ram2,ram3,ram4,ram5,ram6);
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
                    Resolution = "7680x4320 pixels",
                    Type = "GDDR5",
                    Width = 278,
                    Url = "https://www.pcgarage.ro/placi-video/gigabyte/geforce-gtx-1060-g1-gaming-3gb-ddr5-192-bit/"
                };
                var videocard4 = new VideoCard
                {
                    Title = "GIGABYTE GeForce GTX 1080 Ti GAMING OC 11GB DDR5X 352-bit",
                    Price = 4601.79,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/1415042/1474626/full/geforce-gtx-1080-ti-gaming-oc-11gb-ddr5x-352-bit-9339afd86a8c30d416dbc05616195577.jpg",
                    Interface = "PCI Express x16 3.0",
                    BaseFrequency = 1544,
                    GpuBoostClock = 1657,
                    MemoryFrequency = 11010,
                    MemorySize = 11,
                    MemoryBus = 352,
                    Resolution = "7680x4320 pixels",
                    Type = "GDDR5",
                    Width = 280,
                    Url = "https://www.pcgarage.ro/placi-video/gigabyte/geforce-gtx-1080-ti-gaming-oc-11gb-ddr5x-352-bit/"
                };
                var videocard5 = new VideoCard
                {
                    Title = "Palit GeForce GTX 1080 Super JetStream 8GB GDDR5X 256-bit",
                    Price = 2732.66,
                    ImageUrl =
                        "https://3.grgs.ro/images/products/1/1094679/1406166/full/geforce-gtx-1080-super-jetstream-8gb-gddr5x-256-bit-b337f7f2c59786ca00fd010b901aa8b9.jpg",
                    Interface = "PCI Express x16 3.0",
                    BaseFrequency = 1708,
                    GpuBoostClock = 1847,
                    MemoryFrequency = 10000,
                    MemorySize = 8,
                    MemoryBus = 256,
                    Resolution = "7680x4320 pixels",
                    Type = "GDDR5",
                    Width = 285,
                    Url = "https://www.pcgarage.ro/placi-video/palit/geforce-gtx-1080-super-jetstream-8gb-gddr5x-256-bit/"
                };
                var videocard6 = new VideoCard
                {
                    Title = "ASUS GeForce GTX 1070 Ti STRIX GAMING A8G 8GB DDR5 256-bit",
                    Price = 2960.39,
                    ImageUrl =
                        "https://1.grgs.ro/images/products/1/1475490/1597666/full/geforce-gtx-1070-ti-strix-gaming-a8g-8gb-ddr5-256-bit-544cdff8fc922c847f1b391e413e8b0d.jpg",
                    Interface = "PCI Express x16 3.0",
                    BaseFrequency = 1607,
                    GpuBoostClock = 1759,
                    MemoryFrequency = 8008,
                    MemorySize = 8,
                    MemoryBus = 256,
                    Resolution = "7680x4320 pixeli",
                    Type = "GDDR5",
                    Width = 298,
                    Url = "https://www.pcgarage.ro/placi-video/asus/geforce-gtx-1070-ti-strix-gaming-a8g-8gb-ddr5-256-bit/"
                };
                context.VideoCards.AddRange(videocard1,videocard2,videocard3,videocard4,videocard5,videocard6);
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
                var storage4 = new Storage
                {
                    Title = "Seagate BarraCuda 4TB SATA-III 5900RPM 64MB",
                    Price = 599.99,
                    ImageUrl = "https://3.grgs.ro/images/products/1/1025736/1407646/full/barracuda-500gb-sata-iii-7200rpm-16mb-c03782da177728a63b5f5d6b944018d2.jpg",
                    Capacity = "4 TB",
                    FormFactor = "3.5 inch",
                    Interface = "SATA-III",
                    ReadSpeed = "",
                    WriteSpeed = "",
                    Rpm = "5900 RPM",
                    Url = "https://www.pcgarage.ro/hard-disk-uri/seagate/barracuda-4tb-sata-iii-5900rpm-64mb/"
                };
                var storage5 = new Storage
                {
                    Title = "Hard disk WD Blue 1TB SATA-III 7200 RPM 64MB",
                    Price = 219.99,
                    ImageUrl = "https://2.grgs.ro/images/products/1/1457254/1531027/full/545s-series-256gb-sata-iii-25-inch-e9ec1523e5079617dfba68a045b48ccf.jpg",
                    Capacity = "128 GB",
                    FormFactor = "2.5 inch",
                    Interface = "SATA-III",
                    ReadSpeed = "550 MB/s",
                    WriteSpeed = "440 MB/s",
                    Rpm = "0",
                    Url = "https://www.pcgarage.ro/ssd/intel/ssd-intel-545s-series-128gb-sata-iii-25-inch/"
                };
                var storage6 = new Storage
                {
                    Title = "Intel 760p Series 128GB PCI Express 3.0 x4 M.2 2280",
                    Price = 382.11,
                    ImageUrl = "https://4.grgs.ro/images/products/1/1634078/1637132/full/760p-series-256gb-pci-express-30-x4-m2-2280-ea223a0073fbd79fab00ed0d9febbe47.jpg",
                    Capacity = "128 GB",
                    FormFactor = "M.2",
                    Interface = "SATA-III",
                    ReadSpeed = "1640 MB/s",
                    WriteSpeed = "650 MB/s",
                    Rpm = "0",
                    Url = "https://www.pcgarage.ro/ssd/intel/760p-series-128gb-pci-express-30-x4-m2-2280/"
                };
                context.Storages.AddRange(storage1,storage2,storage3,storage4,storage5,storage6);
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
                var powersupply4 = new PowerSupply
                {
                    Title = "Seasonic M12II-620 EVO Edition Bronze 620W",
                    Price = 179.74,
                    ImageUrl =
                        "https://1.grgs.ro/images/products/1/1703884/1704464/full/fx700b-700w-bulk-25b092993f2415a8a546223fe595f417.jpg",
                    Certificate = "-",
                    Cooler = "1x 140 mm",
                    Efficiency = "85 %",
                    IsModular = true,
                    Pfc = "Active",
                    Power = "700 W",
                    Url = "https://www.pcgarage.ro/surse/keepout/fx700b-700w-bulk/"
                };
                var powersupply5 = new PowerSupply
                {
                    Title = "Seasonic M12II-620 EVO Edition Bronze 620W",
                    Price = 196.50,
                    ImageUrl =
                        "https://5.grgs.ro/images/products/1/1517618/1536738/full/hpe-500br-a12s-646c638df72662db7d8c60ab51f6c980.jpg",
                    Certificate = "80+ Bronze",
                    Cooler = "1x 120 mm",
                    Efficiency = "85 %",
                    IsModular = true,
                    Pfc = "Active",
                    Power = "500 W",
                    Url = "https://www.pcgarage.ro/surse/sirtec-high-power/500br-a12s-80-plus-bronze-500w/"
                };
                var powersupply6 = new PowerSupply
                {
                    Title = "Segotep H9PLUS+ 520W",
                    Price = 209.99,
                    ImageUrl =
                        "https://4.grgs.ro/images/products/1/1175151/1429762/full/segotep-nuclear-aircraft-carrier-h9plus-plus-520w-modular-psu-34faf545f2102abdd4d03715cc2ecd65.jpg",
                    Certificate = "80+ Bronze",
                    Cooler = "1x 120 mm",
                    Efficiency = "87 %",
                    IsModular = true,
                    Pfc = "Active",
                    Power = "520 W",
                    Url = "https://www.pcgarage.ro/surse/segotep/h9plus-plus-520w/"
                };
                context.PowerSupplies.AddRange(powersupply1,powersupply2,powersupply3,powersupply4,powersupply5,powersupply6);
                context.SaveChanges();
            }

        }
    }
}
