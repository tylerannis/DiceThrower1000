using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceThrower("10d6");
            DiceThrower("3d20");
            DiceThrower("100d6");
            Console.ReadKey();
        }

        static void DiceThrower(string diceString)
        {
            
            //Index 0 = throws, Index 1 = faces
            List<string> diceList = diceString.Split('d').ToList();
            //String to int
            int faces = int.Parse(diceList[0]);
            int rolls = int.Parse(diceList[1]);
           
            //Random # Generator
            Random rng = new Random();
            Console.WriteLine("\nThrowing: " + diceString);
            Console.Write("Results: ");
            for (int i = 0; i <= rolls; i++)
            {
                
                Console.Write(rng.Next(1, faces) + " ");
            }

        }
    }
}
   