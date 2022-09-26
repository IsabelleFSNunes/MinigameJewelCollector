using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector_
{
    public class Map
    {
        public string[,] map { get; set; }

        public Robot robot { get; set; }
        public Map(int x, int y)
        {
            map = new string[x,y];
            robot = new Robot();
            initializeMap();
            
        }
        public void PrintMap() 
        {
            for (int i = 0; i < this.map.GetLength(0); i++) {
                for (int j = 0; j < this.map.GetLength(1); j++) {
                    Console.Write(this.map[i,j]);
                }
                Console.Write("\n");
            }
        }

        public void initializeMap(){
            for (int i = 0; i < this.map.GetLength(0); i++) {
                for (int j = 0; j < this.map.GetLength(1); j++) {
                    if(robot.x == i && robot.y == j)
                        map[i,j] = "ME " ;
                    else
                        map[i,j] = "-- ";
                }
            }
        }

        public void updateMap(){
            for (int i = 0; i < this.map.GetLength(0); i++) {
                for (int j = 0; j < this.map.GetLength(1); j++) {
                    if(map[i, j].Equals("ME "))
                        map[i, j] = "-- ";
                    if(robot.x == i && robot.y == j)
                        map[i,j] = "ME " ;
                }
            }
        }

        public void addJewelMap(Jewel jewel){
            string simb;
            switch (jewel.tj.type_j)
            {
                case TypeJewel.BLUE: simb = "JB ";  break;
                case TypeJewel.GREEN: simb = "JG ";  break;
                case TypeJewel.RED: simb = "JR ";  break;
                default:  simb = "-- "; break;
            }
            this.map[jewel.x, jewel.y] = simb;
            updateMap();
        }

        public void addObstacleMap(Obstacle obstacle){
            string simb;
            switch (obstacle.type_o)
            {
                case TypeObstacle.WATER: simb = "## ";  break;
                case TypeObstacle.TREE: simb = "$$ ";  break;
                default:  simb = "-- "; break;
            }
            this.map[obstacle.x, obstacle.y] = simb;
        }

        // public void Collect()
        // {
        //     if(map[robot.x, robot.y+] == )
        // }

    }
}