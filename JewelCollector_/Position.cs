using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector_
{
    public class Position
    {
        public int x { get; set; }

        public int y { get; set; }

        /// <summary>
        /// Configurando a posicao, podendo ser usada para joia ou obstaculos
        /// </summary>
        /// <param name="x"> coordinate x </param>
        /// <param name="y"> coordinate y </param>
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
    }
}