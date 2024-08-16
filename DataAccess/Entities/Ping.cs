using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Ping
    {
        public int pingId { get; set; }
        public DateTime time { get; set; }
        public string status { get; set; }
    }
}
