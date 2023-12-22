﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.Product
{
    public class Offcode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }

        public virtual List<ProductsTOOffcodes> Products { get; set; }
    }
}
