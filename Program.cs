using System;

namespace Creating_Mario
{
    class Program
    {

        public struct Mario
        {
            public enum Size
            {
                small,
                large
            }
            public int numOfLives;
            public string currentLevel;
            public Size sizeofMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numOfCoins;
            static void Main(string[] args)
            {
                Mario mario = new Mario();
                mario.numOfLives = 3;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.small;
                mario.canShootFireBalls = false;
                mario.isJumping = false;
                


                Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
                

                mario.numOfLives = 3;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.small;
                mario.canShootFireBalls = false;
                mario.isJumping = true;


                Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");


                mario.numOfLives = 3;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.small;
                mario.canShootFireBalls = false;
                mario.isJumping = false;


                Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");

                mario.numOfLives += 1;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.small;
                mario.canShootFireBalls = false;
                mario.isJumping = false;


                Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");

                mario.numOfLives = 4;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.small;
                mario.canShootFireBalls = true;
                mario.isJumping = false;



                Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");

                mario.numOfLives = 4;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.large;
                mario.canShootFireBalls = true;
                mario.isJumping = false;



                Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");

                mario.numOfLives = 4;
                mario.currentLevel = "World 1-1";
                mario.sizeofMario = Mario.Size.large;
                mario.canShootFireBalls = true;
                mario.isJumping = false;
                mario.numOfCoins = 10;



                Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");

                mario.numOfLives = 4;
                mario.currentLevel = "World 1-2";
                mario.sizeofMario = Mario.Size.large;
                mario.canShootFireBalls = true;
                mario.isJumping = false;
            }
        }
    }
}


    
