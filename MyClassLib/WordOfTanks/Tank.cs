using System;
using System.Collections.Generic;
using System.Text;


namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        private string type { get; set; }
        private int ammunition { get; set; }
        private int armor { get; set; }
        private int mobility { get; set; }

        public Tank()
        {
            type = "null";
            ammunition = 0;
            armor = 0;
            mobility = 0;
            
        }
        public Tank(string str ,int x, int y, int z)
        {
            type = str;
            ammunition = x;
            armor = y;
            mobility = z;
        }
        
        public void Print()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Танк \t\t\t\t- " + type);
            Console.WriteLine("Колличество боеукладки\t\t - " + ammunition);
            Console.WriteLine("Ссумарный коэфицент брони\t - " + armor);
            Console.WriteLine("Ссумарный коэфицент маневренности - " + mobility);
            Console.WriteLine("---------------------------------");
        }

        public static Tank operator *(Tank T34, Tank pantera)
        {
            if (T34.ammunition > pantera.ammunition && T34.armor > pantera.armor)
            {
                return T34;
            }
            if (T34.armor > pantera.armor && T34.mobility > pantera.mobility)
            {
                return T34;
            }
            if (T34.mobility > pantera.mobility && T34.ammunition > pantera.ammunition)
            {
                return T34;
            }
            else
            {
                return pantera;
            }
        }
    }    
}
