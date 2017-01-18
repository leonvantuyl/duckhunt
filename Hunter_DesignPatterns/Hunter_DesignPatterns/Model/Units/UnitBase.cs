using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_DesignPatternsGame
{
    public abstract class UnitBase
    {
        public int size { get; set; }
        public int x_Pos { get; set; }
        public int y_Pos { get; set; }
        public string color { get; set; }
        public bool removeFlag { get; internal set; }

        internal void update(float dt)
        {
           
        }
    }
}
