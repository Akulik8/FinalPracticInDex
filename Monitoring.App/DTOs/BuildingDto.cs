﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.DTOs
{
    public class BuildingDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public List<SensorDto> Sensors { get; set; }
    }
}
