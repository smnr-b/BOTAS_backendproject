using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace Business.Mappings
{
    internal class MapPing
    {
        public PingDTO mapSinglePing(Ping entity)
        {
            PingDTO dto = new PingDTO();
            dto.pingNumber = entity.pingId;
            dto.pingStatus = entity.status;// string
            dto.pingTime = entity.time;

            return dto;         
        }
        public List<PingDTO> mapPingList(List<Ping> Entitys)
        {
            List<PingDTO> listDTO = new List<PingDTO>();
            foreach(var item in Entitys)
            {
                PingDTO dto = new PingDTO();
                dto.pingNumber = item.pingId;
                dto.pingStatus = item.status;
                dto.pingTime = item.time;
                   
                listDTO.Add(dto);                                
            }

            return listDTO.OrderByDescending(x => x.pingNumber).Take(10).ToList();
            //return listDTO;

        }
    }
}
