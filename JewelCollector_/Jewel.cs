using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector_
{
    public class Jewel : Position
    {
        public TypeJ tj {get; set; }
        
        public Jewel(int x, int y, TypeJewel t) : base(x,y)
        {
            TypeJ tj = new TypeJ(t);
            this.tj = tj;
        }
    }
}