namespace FindEvidenceMaterial
{
    public class Clue
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
}
