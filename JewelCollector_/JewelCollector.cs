using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JewelCollector_
{
    public class JewelCollector {

        public static void Main() {

            bool running = true;

            // Teste
            Jewel j = new Jewel(1,2, TypeJewel.BLUE);
            Console.WriteLine("Joia adicionada: ");
            string output = JsonConvert.SerializeObject(j,Formatting.Indented);
            Console.WriteLine(output);
            

            do {
                Console.WriteLine("Enter the command: ");
                string command = Console.ReadLine();

                if (command.Equals("quit")) {
                    running = false;
                } 
                // else if (command.Equals("w"))
                // {
                // } else if (command.Equals("a")) {
                // } else if (command.Equals("s")) {
                // } else if (command.Equals("d")) {
                // } else if (command.Equals("g")) {
                // }
            } while (running);
        }
    }
}