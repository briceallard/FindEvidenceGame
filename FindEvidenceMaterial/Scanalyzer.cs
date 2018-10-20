using System;
using System.Drawing;

namespace FindEvidenceMaterial
{
    abstract public class Scanalyzer
    {
        public abstract void GenerateClue();

        public abstract string CreatedString();

        public abstract string FOUND_MESSAGE();

        public abstract void Found(object sender, EventArgs e);

        public static bool IsFound { get; set; }

        public Bitmap GetDirection(int guessCount)
        {
            Bitmap Up = Properties.Resources.keyboard_arrow_up_black_36x36;
            Bitmap Down = Properties.Resources.keyboard_arrow_down_black_36x36;
            Bitmap Left = Properties.Resources.keyboard_arrow_left_black_36x36;
            Bitmap Right = Properties.Resources.keyboard_arrow_right_black_36x36;

            //int xd = Guess.X - Clue.X;
            //int yd = Guess.Y - Clue.Y;

            //if (Math.Abs(xd) < Math.Abs(yd))
            //    return (xd < 0) ? Right : Left;
            //else
            //    return (yd < 0) ? Down : Up;

            if (guessCount % 2 == 0)
                return Guess.X > Clue.X ? Up : Down;
            else
                return Guess.Y > Clue.Y ? Left : Right;
        }

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
