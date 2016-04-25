using System;

namespace BowlingGameMyTake
{
    class Game
    {
        private int[] scores = new int[10];
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int getScore()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    score += 10 + strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    score += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }
      
        private int sumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        static void Main(string[] args)
        {
            Game g = new Game();

            //for (int i = 0; i < 20; i++) //Test Perfect Game, should equal 300
            //{
            //    g.roll(10);
            //}

            //g.roll(5);  //Test 1 spare, should equal 16
            //g.roll(5);
            //g.roll(3);
            //for (int i = 0; i < 17; i++)
            //{
            //    g.roll(0);
            //}


            //g.roll(10);  //Test 1 strike, should equal 24
            //g.roll(3);
            //g.roll(4);
            //for (int i = 0; i < 17; i++)
            //{
            //    g.roll(0);
            //}

            //for (int i = 0; i < 20; i++) //Test Perfect Game, should equal 300
            //{
            //    g.roll(1);
            //}

            for (int i = 0; i < 20; i++) //Test Perfect Game, should equal 300
            {
                g.roll(0);
            }

            Console.Write(g.getScore());
            Console.ReadKey();
        }

    }
}
