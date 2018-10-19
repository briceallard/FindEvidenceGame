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
    public partial class GameForm : MaterialForm
    {
        private static int x;
        private static int y;
        Scanalyzer scanalyzer;
        Stopwatch stopWatch = new Stopwatch();
        Button[,] tmpButton = new Button[x, y];
        BackgroundWorker bgWorker = new BackgroundWorker();

        public static int X { get => x; set => x = value; }
        public static int Y { get => y; set => y = value; }

        int CluesFound = 0;
        int Guesses = 0;

        public GameForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.Text = $"Case #{Utilities.CaseNum}";

            MessageBox.Show("Choose Evidence type to begin!", "CHOOSE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            stopWatch.Start();
        }

        public void GameForm_IsWon()
        {
            bgWorker.CancelAsync();
            stopWatch.Stop();

            MessageBox.Show($"{Utilities.WIN_MESSAGE}{lblStopWatch.Text}!", Utilities.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BTN_SelectEvidence_Click(object sender, EventArgs e)
        {
            if (RB_Weapon.Checked)
                scanalyzer = new Weapon();
            else if (RB_Fingerprint.Checked)
                scanalyzer = new Fingerprint();
            else
                scanalyzer = new DNA();

            scanalyzer.GenerateClue();
            DrawGrid();
        }

        private void DrawGrid()
        {
            int ButtonWidth = 48;
            int ButtonHeight = 48;
            int start_x = 88;
            int start_y = 200;


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tmpButton[i, j] = new Button();
                    tmpButton[i, j].Top = start_x + (i * ButtonHeight);
                    tmpButton[i, j].Left = start_y + (j * ButtonWidth);
                    tmpButton[i, j].Width = ButtonWidth;
                    tmpButton[i, j].Tag = $"{i},{j}";
                    tmpButton[i, j].Height = ButtonHeight;
                    tmpButton[i, j].FlatStyle = FlatStyle.Flat;
                    tmpButton[i, j].FlatAppearance.BorderSize = 1;
                    tmpButton[i, j].FlatAppearance.BorderColor = Color.Black;
                    tmpButton[i, j].Click += new EventHandler(BTN_Grid_Click);
                    this.Controls.Add(tmpButton[i, j]);
                }
            }
        }

        private void DeleteGrid()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    this.Controls.Remove(tmpButton[i, j]);
                }
            }
        }

        public void BTN_Grid_Click(object sender, EventArgs e)
        {
            string[] coords = ((Button)sender).Tag.ToString().Split(',');
            int x = Int32.Parse(coords[0]);
            int y = Int32.Parse(coords[1]);
            Guess guess = new Guess(x, y);
            Guesses++;

            if (scanalyzer.IsMatch())
            {
                scanalyzer.Found(sender, e);

                if (RB_Weapon.Checked)
                    RB_Weapon.Enabled = false;
                else if (RB_Fingerprint.Checked)
                    RB_Fingerprint.Enabled = false;
                else
                    RB_Dna.Enabled = false;

                CluesFound++;
                LBL_CluesFound.Text = $"{CluesFound} / 3";

                if (CheckWin())
                    GameForm_IsWon();
            }
            else
            {
                MessageBox.Show("Guess again!");
                LBL_Guesses.Text = Guesses.ToString();
            }
            //MessageBox.Show($"You clicked on:\nX: {x} Y: {y}");
        }

        private bool CheckWin()
        {
            return (!RB_Weapon.Enabled && !RB_Fingerprint.Enabled && !RB_Dna.Enabled) ? true : false;
        }

        void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimeSpan timeSpan = stopWatch.Elapsed;
            lblStopWatch.Text = String.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);
        }

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

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
