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
        public string rtspServer { get; set; }
        public string protocolConn { get; set; }
        public string portCom { get; set; }
        public int baudrate { get; set; }
        public string droneType { get; set; }
        public int rtspPort { get; set; }
        public int socket { get; set; }
        public string tcpHost { get; set; }
        public int tcpPort { get; set; }
        public string udpHost { get; set; }
        public int udpPort { get; set; }
    }
}
