using System;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    abstract public class Scanalyzer
    {
        public abstract void GenerateClue();

        public abstract string CreatedString();

        public bool IsMatch()
        {
            return (Guess.X == Clue.X && Guess.Y == Clue.Y) ? true : false;
        }

    }
}
