﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PrepareDataAPI.Models
{
    public partial class Level
    {
        public int Levelid { get; set; }
        public string Levelname { get; set; }
        public int Superlevelid { get; set; }
    }
}