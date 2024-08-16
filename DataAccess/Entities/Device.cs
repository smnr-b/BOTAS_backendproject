using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Device
    {
        public int pingID { get; set; }
        public string cihazAdi { get; set; }
        public string cihazTuru { get; set; }
        public string IP { get; set; }
        public string enlem { get; set; }
        public string boylam { get; set; }
        public int rootID { get; set; }
        public int Id { get; set; }
    }
}
