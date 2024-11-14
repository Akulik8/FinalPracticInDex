﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.DTOs
{
    public class NotificationDto
    {
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
    }

}
