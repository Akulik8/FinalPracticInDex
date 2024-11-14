using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.DTOs
{
    public class SensorDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string GeoLocation { get; set; }
        public string PhotoUrl { get; set; }
        public double BatteryLevel { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public DateTime LastDataReceived { get; set; }
    }
}
