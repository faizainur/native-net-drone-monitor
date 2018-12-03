using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace native_net_drone_monitor
{
    public class Drone
    {
        public string profileName { get; set; }
        public string connMethod { get; set; }
        public string ipAddress { get; set; }
        public string protocolConn { get; set; }
        public string portCom { get; set; }
        public int baudrate { get; set; }
        public string droneType { get; set; }
        public int port { get; set; }
        public int socket { get; set; }
    }
}
