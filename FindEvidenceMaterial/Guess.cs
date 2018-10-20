/****************************************************************
 * Brice Allard
 * Program 5 - Find Evidence Game
 * 10/18/2018
 *
 * Description: Acting as a detective, you must find the evidence
 *  located within a grid of buttons. If you guess wrong it will
 *  produce a hint pointing to the location of the clue.
 *  There are 3 clues to find and once all 3 have been found
 *  the game is won.
 ***************************************************************/

namespace FindEvidenceMaterial
{
    /**
     * Guess class holding coordinates of users guessed location
     * 
     * @param: none
     * @return: none
    **/
    public class Guess
    {
        // Member data
        public static int X { get; set; }
        public static int Y { get; set; }

        // Default Constructor
        public Guess()
        {
            X = Y = 0;
        }

        // Parameterized Constructor
        public Guess(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
