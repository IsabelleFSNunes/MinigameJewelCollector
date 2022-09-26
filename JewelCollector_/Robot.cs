using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace JewelCollector_
{
    public class Robot:Position
    {
        private List<Jewel> bag {get; set;}

        public int totalValue { get; private set; }
        
        public int energy { get; private set; }
        

        // public event EventHandler OnKeyWPressed;
        
        /// <summary>
        /// Initializing at origin position on map
        /// </summary>
        public Robot():base(0, 0)
        {
            this.bag = new List<Jewel>();
            this.totalValue = 0;
            this.energy = 5;
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
            this.totalValue = 0;
            this.energy = 5;
            
        }

        public void ShowBag(){
            Console.WriteLine("-------------------- Bag's Content --------------------");
            foreach (Jewel item in this.bag)
            {
                string output = JsonConvert.SerializeObject(item);
                Console.WriteLine(output);
            }
            Console.WriteLine("-------------------------------------------------------"); 
            Console.WriteLine("Total Bag Value : "+ totalValue);
            Console.WriteLine("-------------------------------------------------------"); 

        }

        public bool AddJewel(Jewel j)
        {
            bool success = false; 
            try
            {
                this.bag.Add(j);
                totalValue = totalValue + ((int)j.tj.type_j);
                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Not is possible add this jewel");
                Console.WriteLine(ex);
            }
            return success; 
        }

        public bool RemoveJewel(Jewel j)
        {
            bool success = false; 
            try
            {
                this.bag.Remove(j);
                totalValue = totalValue - ((int)j.tj.type_j);
                success = true;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Not is possible remove this jewel");
                Console.WriteLine(ex);
            }
            return success; 
        }

        public void MoveUp(int x=1)
        {
            // por enquanto sera feito sem a verificacao da dimensao limite do mapa
            // quando organizar o mapa, sera realizado um tratamento para o mesmo
            this.x -= x;
            this.energy--;
        }

        public void MoveDown(int x=1)
        {
           {
                // por enquanto sera feito sem a verificacao da dimensao limite do mapa
                // quando organizar o mapa, sera realizado um tratamento para o mesmo
                this.x += x;
                this.energy--;
            }
            
        }

        public void MoveLeft(int y=1)
        {
            this.y -= y;
            this.energy--;
        }

        public void MoveRight(int y=1)
        {
            this.y += y;
            this.energy--;
        }

        public void PrintRobot()
        {
            Console.WriteLine("Energy: {0}", energy);
            Console.WriteLine("Bag total items: {0}  | Bag total value:{1}", this.bag.Count,totalValue);
        }
    }
}