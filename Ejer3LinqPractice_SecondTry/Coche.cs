﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
   public class Coche
    {
       public int id { get; set; }
       public string Maker { get; set; }
       public string Model { get; set; }
       public int? Year { get; set; } //nullable
       public string Color { get; set; }
       public double Latitude { get; set; }
       public double Longitude { get; set; }

    }
}
