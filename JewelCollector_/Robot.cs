using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector_
{
    public class Robot:Position
    {
        public List<Jewel> bag {get; set;}

        /// <summary>
        /// Initializing at origin position on map
        /// </summary>
        public Robot():base(0, 0)
        {
            this.bag = new List<Jewel>();
        }

        /// <summary>
        /// Initializing with some coordenate that user will insert
        /// </summary>
        /// <param name="x"> Robot's coordinate x </param>
        /// <param name="y"> Robot's coordinate y </param>
        /// <returns></returns>
        public Robot(int x, int y):base(x, y)
        {
            bag = new List<Jewel>();
        }

        
    }
}