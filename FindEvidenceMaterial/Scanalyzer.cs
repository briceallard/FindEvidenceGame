using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    class Scanalyzer
    {
        private Clue clue;
        private static bool[,] clue_loc = new bool[Utilities.MaxX, Utilities.MaxY];

        private class Clue
        {
            private static int x;
            private static int y;

            public static int X { get => x; set => x = value; }
            public static int Y { get => y; set => y = value; }

            public Clue()
            {
                X = Y = 0;
            }

            public Clue(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public void GenerateClue()
        {
            int randX = Utilities.GenerateRandom(0, Utilities.MaxX);
            int randY = Utilities.GenerateRandom(0, Utilities.MaxY);

            clue = new Clue(randX, randY);
            clue_loc[randX, randY] = true;
            MessageBox.Show($"Random Location Set to:\n[{Scanalyzer.Clue.X},{Scanalyzer.Clue.Y}]");
        }

        public void ClearClue()
        {
            Array.Clear(clue_loc, 0, clue_loc.Length);
        }
    }
}
