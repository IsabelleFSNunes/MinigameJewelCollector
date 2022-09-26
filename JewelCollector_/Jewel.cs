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

        public Jewel(int x, int y, string color): base(x,y)
        {
            if(color.ToLower().Equals("blue"))
            {
                TypeJ tj = new TypeJ(TypeJewel.BLUE);
                this.tj = tj;
            }
            else if(color.ToLower().Equals("green"))
            {
                TypeJ tj = new TypeJ(TypeJewel.GREEN);
                this.tj = tj;
            }
            
            else if(color.ToLower().Equals("red"))
            {
                TypeJ tj = new TypeJ(TypeJewel.RED);
                this.tj = tj;
            }
        }
    }
}
