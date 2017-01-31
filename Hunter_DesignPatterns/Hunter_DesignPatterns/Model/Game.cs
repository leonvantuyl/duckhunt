using Hunter_DesignPatternsGame.Model.Levels;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hunter_DesignPatternsGame.Model
{
    public class Game
    {
        public int score { get; set; }
        public LevelBase currentLevel { get; set; }
        private ConcurrentQueue<Point> actionsQueue;

        public Game()
        {
            score = 0;
            currentLevel = new Level_1();
            actionsQueue = new ConcurrentQueue<Point>();
        }

        internal void update(float dt)
        {
            //Check for stored actions in the actions queue
            checkForActions();

            //Update level
            currentLevel.update(dt);

            //Check for flags
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

        private void checkForActions()
        {
            //TODO only for a single action at the moment
            //Do an action
            Point dequeuedAction = new Point();
            if (actionsQueue.TryDequeue(out dequeuedAction))
            {
                doAction(dequeuedAction);
            }
        }

        internal void doAction(Point action)
        {
            Console.WriteLine("Do Action: " + action.X + action.Y);
            currentLevel.scanForHits(action);            
        }

        public void addAction(Point action)
        {
            actionsQueue.Enqueue(action);
        }
    }
}
