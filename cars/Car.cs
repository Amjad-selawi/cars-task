using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    /// <summary>
    /// Data Model for labeling car data for cleaner code and easier interaction
    /// </summary>
    public class Car
    {
        public string Make { get; set; }
        public string NumberOfDoors { get; set; }
        public string BodyStyle { get; set; }
        public string EngineLocation { get; set;  }
        public string NumberOfCylinders { get; set; }
        public int HorsePower { get; set;  }
        public double price { get; set;  }

        public override string ToString()
        {
            return $"Car ({this.Make}, {this.NumberOfDoors},{this.BodyStyle}, {this.EngineLocation},{this.NumberOfCylinders}, {this.HorsePower}, {this.price} )";
        }
    }
}
