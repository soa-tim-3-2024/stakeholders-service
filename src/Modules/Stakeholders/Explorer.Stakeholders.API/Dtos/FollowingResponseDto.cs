﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Stakeholders.API.Dtos
{
    public class FollowingResponseDto
    {
        public string userId { get; set; }
        public string username { get; set; }
        public string profileImage { get; set; }
    }
}
