using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector_
{
    
    public class Obstacle
    {
        public int type_o { get; set; }

        public Obstacle(int type_o)
        {
            this.type_o = type_o;
        }
    }
}