using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    class Fingerprint : Scanalyzer
    {
        public override void GenerateClue()
        {
            int randX = Utilities.GenerateRandom(0, Utilities.MaxX);
            int randY = Utilities.GenerateRandom(0, Utilities.MaxY);

            Clue clue = new Clue(randX, randY);
            MessageBox.Show(CreatedString());
        }

        public override string CreatedString()
        {
            return $"Fingerprint Created at [{Clue.X},{Clue.Y}]";
        }
    }
}
