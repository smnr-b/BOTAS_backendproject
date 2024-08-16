using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstraction
{
    public interface IPingRepositories
    {
        List<PingDTO> GetAll();
        List<PingDTO> GetByTime(DateTime time);
        List<PingDTO> GetByStatus(string status);
        
    }
}
