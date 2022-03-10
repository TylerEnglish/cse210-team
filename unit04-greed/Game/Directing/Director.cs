using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;
using System;

namespace Unit04.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        public int CELL_SIZE = 10;
        public int Max_Y = 570;
        public int MAX_X = 800;

        public int GEM_SPAWN_RATE = 10;
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
                RemoveOffScreen(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);   

            
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            SpawnNewGems(cast);
            SpawnNewRocks(cast);
            
            ScoreBoard scoreBoard = (ScoreBoard)cast.GetFirstActor("scoreBoard");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> fallingObjects = cast.GetActors("fallingObjects");

            

            foreach (Actor actor in cast.GetAllActors())
            {
                int maxX = videoService.GetWidth();
                int maxY = videoService.GetHeight();
                actor.MoveNext(maxX, maxY);
            } 

            

            List<Actor> removeArtifacts = new List<Actor>();

            foreach (Actor actor in fallingObjects)
            {
                if (IsCollision(robot, actor))
                {
                    FallingObject obj = (FallingObject) actor;
                    int value = obj.GetValue();
                    scoreBoard.AddPoints(value);

                    removeArtifacts.Add(obj);
                }
            }

            
            foreach (Actor item in removeArtifacts)
            {
                cast.RemoveActor("fallingObjects", item);
                
            }

            
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>

        private void SpawnNewGems(Cast cast)
        {
            Random randomGen = new Random();
            int randX = randomGen.Next(0, 1000);
            int ySpeed = randomGen.Next(1,14);
            
            Point point = new Point(randX, 0);
            if (randomGen.Next(0, 100) < GEM_SPAWN_RATE)
            {
                FallingObject gem = new FallingObject();
                gem.SetText("*");
                gem.SetValue(10);
                // gem.SetPosition(point);
                // Point velocity = new Point(randX, gem.GetPosition().GetY() + ySpeed);
                // gem.SetVelocity(velocity);
                cast.AddActor("fallingObjects", gem);
            }
        }

        private void SpawnNewRocks(Cast cast)
        {
            Random randomGen = new Random();
            // int randX = randomGen.Next(0, 1000);
            // Point point = new Point(randX, 0);
            // int ySpeed = randomGen.Next(1,14);
            if (randomGen.Next(0,100) < GEM_SPAWN_RATE)
            {
                FallingObject rock = new FallingObject();
                rock.SetText("o");
                rock.SetValue(-10);
                // rock.SetPosition(point);
                // Point velocity = new Point(randX, rock.GetPosition().GetY() + ySpeed);
                // rock.SetVelocity(velocity);
                cast.AddActor("fallingObjects", rock);
            }
        }

        private void RemoveOffScreen(Cast cast)
        {
            foreach (Actor item in cast.GetActors("fallingObjects"))
            {
                if (item.GetPosition().GetY() >= Max_Y - 5)
                {
                    cast.RemoveActor("fallingObjects", item);
                }
            }
        }

        private bool IsCollision(Actor first, Actor second)
        {
            int size = CELL_SIZE;

            int fX = first.GetPosition().GetX();
            int fY = first.GetPosition().GetY();

            int sX = second.GetPosition().GetX();
            int sY = second.GetPosition().GetY();

            bool isCollided = false;

            if (Math.Abs(fX - sX) < size && Math.Abs(fY - sY) < size)
            {
                isCollided = true;
            }
            return isCollided;
        }
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}