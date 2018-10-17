using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    abstract public class Scanalyzer
    {
        public abstract void GenerateClue();

        public abstract string CreatedString();

        public abstract string FOUND_MESSAGE();

        public abstract void Found(object sender, EventArgs e);

        public bool IsMatch()
        {
            return (Guess.X == Clue.X && Guess.Y == Clue.Y) ? true : false;
        }

        public static string FOUND_TITLE
        {
            get
            {
                return "FOUND";
            }
        }
    }
}
