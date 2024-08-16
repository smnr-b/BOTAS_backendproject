using Business.Abstraction;
using Business.Context;
using Business.Mappings;
using DataAccess.DTOs;
using DataAccess.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Business.Repositories
{
    public class DeviceRepositories : IDeviceRepositories
    {      
        
        public List<DeviceDTO> GetAll()
        {
            using (var context = new AppDbContext())
            {
                var data = context.Devices.ToList();

                var device = new MapDevice().mapDeviceList(data);

                return device;              
            }

            //string jsonData = File.ReadAllText("data.json"); // Burada projemize eklediğimiz dosyayı okuyoruz
            //List<Device> devices = JsonConvert.DeserializeObject<List<Device>>(jsonData); // okuduğumuz dosyayı entity ile eşleştirdik
            
        }

        public DeviceDTO GetByID(int id)
        {

            using (var context = new AppDbContext())
            {
                var data = context.Devices.Where(x => x.pingID == id).FirstOrDefault(); 
                var device = new MapDevice().mapSingleDevice(data);
                return device;
            }

            //string jsonData = File.ReadAllText("data.json");
            //List<Device> devices =JsonConvert.DeserializeObject<List<Device>>(jsonData);
            //var dtoModel = devices.Where(x => x.pingID==id).FirstOrDefault();
            //var dtoMapping = new MapDevice().mapDeviceList(devices);
            //return dtoMapping;
        }

        public DeviceDTO GetByName(string name)
        {
            using (var context = new AppDbContext())
            {
                var data = context.Devices.Where(x => x.cihazAdi.Contains(name)).FirstOrDefault();
                var device = new MapDevice().mapSingleDevice(data);
                return device;
            }

            //string jsonData = File.ReadAllText("data.json");
            //List<Device> devices = JsonConvert.DeserializeObject<List<Device>>(jsonData);
            //var dtoModel = devices.Where(x => x.cihazAdi.Contains(name)).FirstOrDefault();
            //var dtoMapping = new MapDevice().mapSingleDevice(devices);
            //return dtoMapping;
            
        }

    }
}
