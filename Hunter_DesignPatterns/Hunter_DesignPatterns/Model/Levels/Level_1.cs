using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_DesignPatternsGame.Model.Levels
{
    class Level_1 : LevelBase
    {
        public Level_1()
        {
            currentLevel = 1;
            maxUnitCount = 5;
            levelGoal = 20;
            spawnRate = 10;
        }

        public override void spawnUnit()
        {
            addUnit(new BirdNormal());
        }
    }
}
