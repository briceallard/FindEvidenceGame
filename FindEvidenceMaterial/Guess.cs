using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvidenceMaterial
{
    public class Guess
    {
        private static int x;
        private static int y;

        public static int X { get => x; set => x = value; }
        public static int Y { get => y; set => y = value; }

        public Guess()
        {
            X = Y = 0;
        }

        public Guess(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
