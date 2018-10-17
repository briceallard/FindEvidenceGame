using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    public partial class GameForm : MaterialForm
    {
        private static int x;
        private static int y;
        Scanalyzer scanalyzer;
        Button[,] tmpButton = new Button[x, y];

        public static int X { get => x; set => x = value; }
        public static int Y { get => y; set => y = value; }

        public GameForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.Text = $"Case #{Utilities.CaseNum}";

            MessageBox.Show("Choose Evidence type to begin ...");
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

            if (scanalyzer.IsMatch())
            {
                scanalyzer.Found(sender, e);
                DeleteGrid();
            }
            else
                MessageBox.Show("Guess again!");

            //MessageBox.Show($"You clicked on:\nX: {x} Y: {y}");
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
