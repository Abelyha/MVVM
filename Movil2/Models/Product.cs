﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movil2.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}