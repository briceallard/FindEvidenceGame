using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Diagnostics;

namespace FindEvidenceMaterial
{
    abstract public class Scanalyzer
    {
        public abstract void GenerateClue();

        public abstract string CreatedString();

        public abstract string FOUND_MESSAGE();

        public abstract void Found(object sender, EventArgs e);

        public static bool IsFound { get; set; }

        public Bitmap GetDirection()
        {
            Bitmap Up = Properties.Resources.keyboard_arrow_up_black_36x36;
            Bitmap Down = Properties.Resources.keyboard_arrow_down_black_36x36;
            Bitmap Left = Properties.Resources.keyboard_arrow_left_black_36x36;
            Bitmap Right = Properties.Resources.keyboard_arrow_right_black_36x36;

            int xd = Guess.X - Clue.X;
            int yd = Guess.Y - Clue.Y;
            int absX = Math.Abs(xd);
            int absY = Math.Abs(yd);

            if(absX < absY)
                return (xd < 0) ? Left : Right;
            else
                return (yd < 0) ? Down : Up;
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
