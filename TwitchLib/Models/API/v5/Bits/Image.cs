﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.API.v5.Bits
{
    public class Image
    {
        public DarkImage Dark { get; set; }
        public LightImage Light { get; set; }
    }
}
