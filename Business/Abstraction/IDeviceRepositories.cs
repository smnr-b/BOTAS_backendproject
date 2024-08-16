using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTOs;
using DataAccess.Entities;

namespace Business.Abstraction
{
    public interface IDeviceRepositories
    {
        List<DeviceDTO> GetAll();
        DeviceDTO GetByID(int id);
        DeviceDTO GetByName(string name);
    }
}
