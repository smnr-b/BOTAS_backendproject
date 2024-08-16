using Business.Abstraction;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class PingRepositories : IPingRepositories
    {
        public List<PingDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PingDTO> GetByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public List<PingDTO> GetByTime(DateTime time)
        {
            throw new NotImplementedException();
        }
    }
}
