﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class Rating
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int Ratings { get; set; }
        public int Timestamp { get; set; }
    }
}
