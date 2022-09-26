using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector_
{
    
    public class Obstacle:Position
    {
        public TypeObstacle type_o { get; set; }

        public Obstacle(int x, int y, TypeObstacle type_o):base(x,y)
        {
            this.type_o = type_o;
        }

        public Obstacle(int x, int y, string obs):base(x, y)
        {
            if(obs.ToLower().Equals("tree"))
            {
                this.type_o = TypeObstacle.TREE;
            }
            else if(obs.ToLower().Equals("water"))
            {
                this.type_o = TypeObstacle.WATER;
            }
        }
    }
}