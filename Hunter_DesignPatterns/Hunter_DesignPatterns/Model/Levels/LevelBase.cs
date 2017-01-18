﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_DesignPatternsGame.Model.Levels
{
    public abstract class LevelBase
    {
        public int currentLevel { get; set; }
        public int maxUnitCount { get; set; }
       
        public int levelGoal { get; set; }

        public bool endScreen { get; set; }
        public bool levelCompletedFlag { get; set; }

        public int currentUnitCount { get; private set; }
        private List<UnitBase> units;

        public float spawnRate;
        public float currentTime;
        

        public LevelBase()
        {
            units = new List<UnitBase>();
        }

        internal void update(float dt)
        {
            currentTime += dt;
            Console.WriteLine("time" + currentTime);
            if (currentTime >= spawnRate)
            {
                currentTime = 0;
                spawnUnit();
            }        
            foreach (UnitBase unit in units) //TODO possible bug here when removing units
            {
                unit.update(dt);
                if (unit.removeFlag)
                    removeUnit(unit);
            }
        }

        public void checkLevelCompleted(int kills)
        {
            if (kills > levelGoal)
            {
                levelCompletedFlag = true;
            }
        }

        public void addUnit(UnitBase unit)
        {
            if (currentUnitCount  < maxUnitCount)
            {
                Console.WriteLine("unit added");
                units.Add(unit);
                currentUnitCount++;
            }
            else
            {
                Console.WriteLine("unit limit reached");
            }
        }

        public void removeUnit(UnitBase unit)
        {
            Console.WriteLine("unit removed");
            units.Remove(unit);
            currentUnitCount--;
        }

        public abstract void spawnUnit();
    }
}
