namespace MSPBowlingScoring
{
    public class Game
    {
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
            for(int fame = 0; fame< 10; fame++)
            {
               if(isStrike(frameIndex))
               {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex++;
               }
               else if (isSpare(frameIndex))
               {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
               }
               else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
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



        public static void Main()
        {

        }
    }
}
