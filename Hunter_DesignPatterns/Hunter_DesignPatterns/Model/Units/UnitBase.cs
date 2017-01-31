using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hunter_DesignPatternsGame
{
    public abstract class UnitBase
    {
        public int health { get; set; }
        public int size { get; set; }
        public int x_Pos { get; set; }
        public int y_Pos { get; set; }
        public string color { get; set; }
        public bool removeFlag { get; internal set; }

        internal void update(float dt)
        {
           
        }

        internal void attemptHit(Point hit)
        {
            Rect unitZone = new Rect() { Size = new Size() { Height = size, Width = size }, X = x_Pos, Y = y_Pos };
            if (unitZone.Contains(hit))
            {
                health--;
                Console.WriteLine("Unit hit at: " + hit);
            }
        }


    }
}
