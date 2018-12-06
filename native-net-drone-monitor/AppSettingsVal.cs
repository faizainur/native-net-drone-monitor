using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace native_net_drone_monitor
{
    public class AppSettingsVal
    {
        public string aspectRatio { get; set; }
        public bool saveVideoState { get; set; }
        public string videoFormat { get; set; }
        public string savePath { get; set; }
        public string mapsMode { get; set; }
        public string cacheLocation { get; set; }
        public string mapLocation { get; set; }
    }
}
