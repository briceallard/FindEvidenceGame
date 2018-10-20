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
using System.IO;

namespace FindEvidenceMaterial
{
    /**
     * Utility class to maintain static variables and strings that
     * are used throughout the entire program
     * 
     * @param: none
     * @return: none
    **/
    class Utilities
    {
        // Member data
        public static string SettingsPath { get; set; }
        public static bool Settings { get; set; }
        public static int MaxX { get; set; }
        public static int MaxY { get; set; }
        public static int CaseNum { get; set; }
        public static int HighScore { get; set; }

        /**
         * Initialize program with settings document chosen by user
         * 
         * @param: none
         * @return: none
         **/
        public static void ReadSettings()
        {
            try
            {
                string[] lines = File.ReadAllLines(SettingsPath);
                MaxX = Int32.Parse(lines[0]);   // Max X grid size
                MaxY = Int32.Parse(lines[1]);   // Max Y grid size
                CaseNum = Int32.Parse(lines[2]) + 1;    // Case number generator
                lines[2] = CaseNum.ToString();
                File.WriteAllLines(SettingsPath, lines);
                Settings = true;    // Bool to allow next form load
                MessageBox.Show(FILE_SUCCESS, SUCCESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(FILE_ERROR, ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Generates a trully unique integer number using HashCodes
         * 
         * @param:
         *      min (int - minimum number allowed to generate)
         *      max (int - maximum number allowed to generate)
         * @return: 
         *      int - number generated
         **/
        public static int GenerateRandom(int min, int max)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int rand = random.Next(min, max);

            return rand;
        }

        /*
        *
        *  All utility messages are below this point and maintain
        *  the same structure for @params and @returns
        *
        */

        /**
         * Error message when file is not found
         * 
         * @param: none
         * @return: string
         **/
        public static string FILE_ERROR
        {
            get
            {
                return "File Not Found";
            }
        }

        public static string NOFILE_ERROR
        {
            get
            {
                return "No File Selected";
            }
        }
        
        public static string FILE_SUCCESS
        {
            get
            {
                return "File Uploaded";
            }
        }
        
        public static string ERROR_TITLE
        {
            get
            {
                return "ERROR";
            }
        }

        public static string SUCCESS_TITLE
        {
            get
            {
                return "SUCCESS";
            }
        }

        public static string FOUND_MESSAGE
        {
            get
            {
                return "Clue Found!";
            }
        }

        public static string FOUND_TITLE
        {
            get
            {
                return "FOUND";
            }
        }

        public static string WIN_MESSAGE
        {
            get
            {
                return "Congratualations!\n\nYou found all the evidence in ";
            }
        }

        public static string WIN_TITLE
        {
            get
            {
                return "WINNER";
            }
        }
    }
}
