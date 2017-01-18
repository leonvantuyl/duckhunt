using Hunter_DesignPatternsGame.Model.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_DesignPatternsGame.Model
{
    class Game
    {
        public int score { get; set; }
        public LevelBase currentLevel { get; set; }

        public Game()
        {
            score = 0;
            currentLevel = new Level_1();
        }

        internal void update(float dt)
        {
            currentLevel.update(dt);
            if (currentLevel.levelCompletedFlag)
            {
                if(currentLevel.currentUnitCount == 0)
                {
                    nextLevel();
                }
            }
        }

        private void nextLevel()
        {
           //get next level from levels map
        }
    }
}
