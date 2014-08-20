﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCutting.DomainBase;

namespace Domain.Events
{
    public class MeterStateChanged :  IDomainEvent
    {
        public string SerialNumber { get; set; }
     
        public Domain.Meter.MeterState State { get; set; }
        
    }
}
