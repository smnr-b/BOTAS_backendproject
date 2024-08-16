using Business.Mappings;
using DataAccess.DTOs;
using DataAccess.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstraction.Services
{
    public interface IPingService
    {
        public Task<List<Ping>> GetAll();
        

    }
}
