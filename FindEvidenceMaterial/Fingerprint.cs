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

        public override void Found(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.BackgroundImage = FindEvidenceMaterial.Properties.Resources.fingerprint_black_36x36;
            button.BackgroundImageLayout = ImageLayout.Center;
            MessageBox.Show(FOUND_MESSAGE(), FOUND_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public override string CreatedString()
        {
            return $"Fingerprint Created at [{Clue.X},{Clue.Y}]";
        }

        public override string FOUND_MESSAGE()
        {
            return "Fingerprint Found!";
        }
    }
}
