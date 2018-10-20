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

using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics;

namespace FindEvidenceMaterial
{
    /* Class: GameForm (Inherits from Base Class MaterialForm)
     * 
     * Description: Game controls and design are here
     */
    public partial class GameForm : MaterialForm
    {
        // Member data
        Scanalyzer scanalyzer;
        Stopwatch stopWatch = new Stopwatch();
        Button[,] tmpButton = new Button[X, Y];
        BackgroundWorker bgWorker = new BackgroundWorker();

        public static int X { get; set; }
        public static int Y { get; set; }

        int CluesFound = 0;
        int Guesses = 0;

        /**
         * GameForm: Primary source of game interactions where user will select
         *      a clue to search for by clicking buttons within a grid. Once all
         *      three clues are found the game will be won.
         * 
         * @param: none
         * @return: none
         **/
        public GameForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.Text = $"Case #{Utilities.CaseNum}";   // Update case number label

            // Instructional message
            MessageBox.Show("Choose Evidence type to begin!", "CHOOSE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open new thread and begin background worker for timer
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
        }

        /**
         * On form load, begins timer on new thread
         * 
         * @param: sender (Object Form)
         * @return: none
         **/
        private void GameForm_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            stopWatch.Start();
        }

        /**
         * When game is won, timer stops and WIN message displayed
         * 
         * @param: none
         * @return: none
         **/
        public void GameForm_IsWon()
        {
            bgWorker.CancelAsync();
            stopWatch.Stop();

            MessageBox.Show($"{Utilities.WIN_MESSAGE}{lblStopWatch.Text}!", Utilities.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /**
         * User selection for evidence to search for
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_SelectEvidence_Click(object sender, EventArgs e)
        {
            // Assign scanalyzer to appropriate type
            if (RB_Weapon.Checked)
                scanalyzer = new Weapon();
            else if (RB_Fingerprint.Checked)
                scanalyzer = new Fingerprint();
            else
                scanalyzer = new DNA();

            HideHintImages();           // Erase previously given clues
            scanalyzer.GenerateClue();  // Get coordinates for clue
            DrawGrid();                 // Draw board/place 
        }

        /**
         * Create grid of form for gameboard
         * 
         * @param: none
         * @return: none
         **/
        private void DrawGrid()
        {
            // Button Initialization data
            int ButtonWidth = 48;   
            int ButtonHeight = 48;
            int start_x = 88;
            int start_y = 200;

            for (int i = 0; i < X; i++) // Rows
            {
                for (int j = 0; j < Y; j++) // Columns
                {
                    tmpButton[i, j] = new Button();
                    tmpButton[i, j].Top = start_x + (i * ButtonHeight);
                    tmpButton[i, j].Left = start_y + (j * ButtonWidth);
                    tmpButton[i, j].Width = ButtonWidth;
                    tmpButton[i, j].Tag = $"{i},{j}";   // For getting coordinates later
                    tmpButton[i, j].Height = ButtonHeight;
                    tmpButton[i, j].FlatStyle = FlatStyle.Flat;
                    tmpButton[i, j].FlatAppearance.BorderSize = 1;
                    tmpButton[i, j].FlatAppearance.BorderColor = Color.Black;
                    tmpButton[i, j].Click += new EventHandler(BTN_Grid_Click);
                    this.Controls.Add(tmpButton[i, j]);
                }
            }
        }

        /**
         * Grid button click function to determine if user found clue
         * 
         * @param: sender (Button)
         * @return: none
         **/
        public void BTN_Grid_Click(object sender, EventArgs e)
        {
            // Get button data from .tag (coordinates of button in grid)
            string[] coords = ((Button)sender).Tag.ToString().Split(',');
            int x = Int32.Parse(coords[0]); // X value of Button
            int y = Int32.Parse(coords[1]); // Y value of Button

            // Place coordinates in class Guess for easy comparison
            Guess guess = new Guess(x, y);
            Guesses++;

            // If (Button) is same location as clue
            if (scanalyzer.IsMatch())
            {
                scanalyzer.Found(sender, e);

                // Disable clue that was found
                if (RB_Weapon.Checked)
                    RB_Weapon.Enabled = false;
                else if (RB_Fingerprint.Checked)
                    RB_Fingerprint.Enabled = false;
                else
                    RB_Dna.Enabled = false;

                CluesFound++;
                LBL_CluesFound.Text = $"{CluesFound} / 3";

                // Check if all clues found = GAMEWIN!
                if (CheckWin())
                    GameForm_IsWon();
            }
            else
            {
                // Generate appropriate clue direction and place in Button bg image
                ((Button)sender).BackgroundImage = scanalyzer.GetDirection(Guesses);
                ((Button)sender).BackgroundImageLayout = ImageLayout.Center;
                // MessageBox.Show("Guess again!");
                LBL_Guesses.Text = Guesses.ToString();
            }
            // *** Uncomment for testing button click location
            // MessageBox.Show($"You clicked on:\nX: {x} Y: {y}");
        }

        /**
         * Checks if all radio buttons are disabled. If true, game won
         * 
         * @param: none
         * @return: bool
         **/
        private bool CheckWin()
        {
            return (!RB_Weapon.Enabled && !RB_Fingerprint.Enabled && !RB_Dna.Enabled) ? true : false;
        }

        /**
         * Delete all previously generated hints
         * 
         * @param: none
         * @return: none
         **/
        private void HideHintImages()
        {
            // loop through all Buttons on form
            foreach(var button in Controls.OfType<Button>())
            {
                /*
                 * Comment code below is to leave found clues images on grid
                 * For now, all background images are reset
                 */

                // Get Clue coordinates in string
                //string clue = $"{Clue.X},{Clue.Y}";

                // Compare button tag to Clue coordinates
                //if (clue != button.Tag.ToString())
                    button.BackgroundImage = null;
            }
        }

        /**
         * BackgroundWorker for Timer format
         * 
         * @param: sender (Label)
         * @return: none
         **/
        void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimeSpan timeSpan = stopWatch.Elapsed;
            lblStopWatch.Text = String.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);
        }

        /**
         * BackgroundWorker generation of new thread
         * 
         * @param: sender (bgWorker)
         * @return: none
         **/
        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                bgWorker.ReportProgress(0);
                System.Threading.Thread.Sleep(1000);
                if (!stopWatch.IsRunning)
                {
                    break;
                }
            }
        }

        /**
         * Button click even to close game
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Button click event to restart game
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_StartNew_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
