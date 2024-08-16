using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class PingDTO
    {
        public int pingNumber { get; set; }
        public DateTime pingTime { get; set; }
        public string pingStatus { get; set; }
    }
}
