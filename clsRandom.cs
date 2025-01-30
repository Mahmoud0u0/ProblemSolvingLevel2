using System;


namespace ProblemSolveng_Level_2_From_2_to_10
{
    internal class clsRandom
    {
        static Random random = new Random();

        static public int RandomNumbers(int from, int to)
        {
            return random.Next(from, to + 1);
        }


        public enum enRandomChar { SmallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };

        static public char GetRandomCharacter(enRandomChar randomChar)
        {
            char character = ' ';

            switch (randomChar)
            {
                case enRandomChar.SmallLetter:
                    character = Convert.ToChar(RandomNumbers(97, 122));
                    break;
                case enRandomChar.CapitalLetter:
                    character = Convert.ToChar(RandomNumbers(65, 90));
                    break;
                case enRandomChar.SpecialCharacter:
                    character = Convert.ToChar(RandomNumbers(33, 47));
                    break;
                case enRandomChar.Digit:
                    character = Convert.ToChar(RandomNumbers(48, 57));
                    break;
                default:
                    character = ' ';
                    break;
            }

            return character;
        }


    }
}
