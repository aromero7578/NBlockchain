﻿using NBlockChain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBlockChain.Models
{
    public class StaticNetworkParameters : INetworkParameters
    {
        public TimeSpan BlockTime { get; set; }
        public uint Difficulty { get; set; }
        public uint HeaderVersion { get; set; }
        public decimal ExpectedContentThreshold { get; set; }
    }
}