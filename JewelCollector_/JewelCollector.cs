using System.ComponentModel;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using JewelCollector_;

using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace JewelCollector_
{
    public class JewelCollector {

        public static void Main(string[] args) {
            
            bool running = true;
            bool play = false;

            

            Console.WriteLine("Insert the dimension map (x,y): ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Map m = new Map(x,y);

            m.PrintMap();

             KeyPressed key_pressed = new KeyPressed(); // my
            ConsoleKeyInfo key;
            key_pressed.KeyPress += (sender, e) => {
                Console.Write(e.key.KeyChar.ToString());
                if (e.key.KeyChar == 'w')
                    m.robot.MoveUp();
                else if (e.key.KeyChar == 'a') {
                    m.robot.MoveLeft();
                } else if (e.key.KeyChar == 's') {
                    m.robot.MoveDown();
                } else if (e.key.KeyChar == 'd') {
                    m.robot.MoveRight();
                } else if (e.key.KeyChar == 'g') {
                    m.robot.Collect();
                }
                else if(e.key.KeyChar == 'q'){
                    running = false; 
                }
            };

            Console.WriteLine("Start to Play");
            do{
                string inputStr = Console.ReadLine();

                if(inputStr.ToLower().Equals("start"))
                    play = true;
                else {
                    StringToDimension(inputStr, out string type, out x, out y);

                    if(TypeJ.isJewel(type))
                        m.addJewelMap(new Jewel(x,y,type));
                    
                    if(TypeO.isObstacle(type))
                        m.addObstacleMap(new Obstacle(x,y,type));
                }   

            }while(!play);
            
            do{
                Console.Clear();
                m.updateMap();
                m.PrintMap();
                m.robot.PrintRobot();

                Console.Write("Enter the command: ");
                key = Console.ReadKey(true);
                key_pressed.OnKeyPress(key);
            }while(running);
        }

        static void StringToDimension(string input, out string obstacle_or_color, out int x, out int y)
        {
            string[] sub = input.Split(',', ' ', '-', '(', ')');
            // foreach (var item in sub)
            // {
            //     Console.WriteLine(item);
            // }

            obstacle_or_color = sub[0].ToLower();
            x = Convert.ToInt32(sub[4]);
            y = Convert.ToInt32(sub[6]);

        }
    }
}