
using Hunter_DesignPatterns.Utility;
using Hunter_DesignPatterns.View;
using Hunter_DesignPatternsGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hunter_DesignPatternsGame.Controller
{
    class MainController
    {
        private GamePanel window;
        private Game game;
        private Thread gameLoop;
        public bool gameIsRunning;
        public bool IsPaused;

        public MainController(GamePanel window, Game game)
        {
            this.window = window;
            this.game = game;
        }

        public void startGame()
        {
            gameLoop = new Thread(new ThreadStart(runGame));
            gameLoop.Start();
        }

        private void runGame()
        {
            GameTimer timer = new GameTimer();
            gameIsRunning = true;
            Console.WriteLine("Running game");

            double currentFPS = 0;
            float previousTime = 0;
            float dt = 0;
            int frames = 0;

            timer.Start();
                            
            while (gameIsRunning)
            {                              
                dt = timer.DeltaTime;
                if ((timer.TotalTime  - previousTime) > 1)
                {
                    currentFPS = frames / (timer.TotalTime - previousTime); 
                    previousTime = timer.TotalTime;
                    frames = 0;
                    Console.WriteLine("FPS: " + currentFPS);
                }                
                
                game.update(dt);                
                window.render(dt);
                timer.Tick();
                frames++;
            }           
        }

        public void pauseGame()
        {
            IsPaused = true;
        }

        public void resumeGame()
        {
            IsPaused = false;
        }

        public void addAction()
        {

        }
    }    
}
