﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Dtos
{
    public class CheckCompletitionDto
    {
        public long TourId { get; set; }
        public long TouristId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
