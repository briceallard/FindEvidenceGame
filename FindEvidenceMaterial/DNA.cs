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
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    /* Class: DNA (Inherits from Base Class Scanalyzer)
     * 
     * Description: Inherited class member for DNA clue
     */
    class DNA : Scanalyzer
    {
        // Override GenerateClue to produce a DNA sample
        public override void GenerateClue()
        {
            // Get random coordinates to place clue
            int randX = Utilities.GenerateRandom(0, Utilities.MaxX);
            int randY = Utilities.GenerateRandom(0, Utilities.MaxY);

            // Place clue into new Clue object
            Clue clue = new Clue(randX, randY);

            // *** Uncomment for testing
            MessageBox.Show(CreatedString());
        }

        // Override background image and message when DNA found
        // Arguments:
        //  sender - Button
        public override void Found(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.BackgroundImage = FindEvidenceMaterial.Properties.Resources.icons8_dna_helix_36x36;
            button.BackgroundImageLayout = ImageLayout.Center;
            IsFound = true;
            MessageBox.Show(FOUND_MESSAGE(), FOUND_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Override string for testing purposes
        // *** Uncomment for testing
        public override string CreatedString()
        {
            return $"DNA Created at [{Clue.X},{Clue.Y}]";
        }

        // Override string DNA found message
        public override string FOUND_MESSAGE()
        {
            return "DNA Found!";
        }
    }
}
