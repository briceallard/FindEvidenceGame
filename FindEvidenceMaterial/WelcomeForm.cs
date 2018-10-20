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
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace FindEvidenceMaterial
{
    /**
     * Class: WelcomeForm (inherited from MaterialForm)
     * Description: Initial window form that gathers settings
     *      data from user for use throughout entirety of program
     * 
     * @param: none
     * @return: none
    **/
    public partial class WelcomeForm : MaterialForm
    {
        public WelcomeForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        /**
         * Button click even to open File selection dialog for settings
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if(file.ShowDialog() == DialogResult.OK)
            {
                string path = file.FileName;
                TB_Path.Text = path;
            }
        }

        /**
         * Button click even to upload File selection for settings
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_Upload_Click(object sender, EventArgs e)
        {
            Utilities.SettingsPath = TB_Path.Text;
            Utilities.ReadSettings();
            LBL_MaxSize.Text = $"* Maximum Size Allowed: {Utilities.MaxX} X {Utilities.MaxY}";
        }

        /**
         * Picturebox mouse enter event for graphical delight
         * 
         * @param: sender (Picturebox)
         * @return: none
         **/
        private void PB_Fingerprint_MouseEnter(object sender, EventArgs e)
        {
            PB_Fingerprint.Visible = true;
        }

        /**
         * Picturebox mouse exit event for graphical delight
         * 
         * @param: sender (Picturebox)
         * @return: none
         **/
        private void PB_Fingerprint_MouseExit(object sender, EventArgs e)
        {
            PB_Fingerprint.Visible = false;
        }

        /**
         * Button click even to start game
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (Utilities.Settings)
            {
                GameForm.X = Int32.Parse(TB_GRIDX.Text);
                GameForm.Y = Int32.Parse(TB_GRIDY.Text);

                GameForm gameForm = new GameForm();
                this.Hide();
                gameForm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(Utilities.NOFILE_ERROR, Utilities.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /**
         * Button click event to exit game
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Button click event to open high score form
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_Highscore_Click(object sender, EventArgs e)
        {
            HighScore wf = new HighScore();
            wf.ShowDialog();
        }
    }
}
