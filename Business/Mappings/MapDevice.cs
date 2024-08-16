using DataAccess.DTOs;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappings
{
    public class MapDevice
    {
        public DeviceDTO mapSingleDevice(Device entity)
        {
            DeviceDTO dto = new DeviceDTO();
            dto.pingNo = entity.pingID;
            dto.IPNumber = entity.IP;

            return dto;
        }

        public List<DeviceDTO> mapDeviceList(List<Device> Entitys) 
        {
            List<DeviceDTO> deviceList = new List<DeviceDTO>();
            foreach (var item in Entitys)
            {
                DeviceDTO dto = new DeviceDTO();
                dto.pingNo = item.pingID;
                dto.IPNumber = item.IP;
                
                deviceList.Add(dto);
            }
            return deviceList;
        }
    
    }
}
