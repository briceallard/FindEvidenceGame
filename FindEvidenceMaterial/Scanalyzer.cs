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

using System;
using System.Drawing;

namespace FindEvidenceMaterial
{
    /**
     * Class: Scanalyzer (BASE CLASS FOR ALL CLUES)
     * Description: Base class for all clues with member data
     *      to be shared between DNA, Fingerprint, and Weapon.
     * 
     * @param: none
     * @return: none
    **/
    abstract public class Scanalyzer
    {
        // Abstract methods
        public abstract void GenerateClue();
        public abstract string CreatedString();
        public abstract string FOUND_MESSAGE();
        public abstract void Found(object sender, EventArgs e);

        // Member data
        public static bool IsFound { get; set; }

        /**
         * Generation of hint data formed here.
         * Images are .png's in resources
         * 
         * @param: guessCount (int)
         * @return: Bitmap (which image to be placed)
         **/
        public Bitmap GetDirection(int guessCount)
        {
            // Images to be used for hints
            Bitmap Up = Properties.Resources.keyboard_arrow_up_black_36x36;
            Bitmap Down = Properties.Resources.keyboard_arrow_down_black_36x36;
            Bitmap Left = Properties.Resources.keyboard_arrow_left_black_36x36;
            Bitmap Right = Properties.Resources.keyboard_arrow_right_black_36x36;

            /**
            *   This is still a work in progress. Hoping to develop a better
            *   process for handling the clue pointers to avoid wrong arrows
            *   being placed if Guess is located on the same row or column
            *   as Clue. Needs more work!
            **/

            // *** Uncomment once methodology is correct
            //int xd = Guess.X - Clue.X;
            //int yd = Guess.Y - Clue.Y;

            //if (Math.Abs(xd) < Math.Abs(yd))
            //    return (xd < 0) ? Right : Left;
            //else
            //    return (yd < 0) ? Down : Up;

            // *** If above block is uncommented, comment below!
            if (guessCount % 2 == 0)
                return Guess.X > Clue.X ? Up : Down;
            else
                return Guess.Y > Clue.Y ? Left : Right;
        }

        /**
         * Determines if user Guess is == to Clue coordinates
         * 
         * @param: none
         * @return: bool
         **/
        public bool IsMatch()
        {
            return (Guess.X == Clue.X && Guess.Y == Clue.Y) ? true : false;
        }

        /**
         * Default found message that was used before abstract methods
         * Mostly for testing, can probably be deleted
         * 
         * @param: none
         * @return: string
         **/
        public static string FOUND_TITLE
        {
            get
            {
                return "FOUND";
            }
        }
    }
}
