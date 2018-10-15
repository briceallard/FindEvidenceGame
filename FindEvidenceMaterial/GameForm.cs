using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace FindEvidenceMaterial
{
    public partial class GameForm : MaterialForm
    {
        Scanalyzer scanalyzer = new Scanalyzer();
        private static int x;
        private static int y;

        public static int X { get => x; set => x = value; }
        public static int Y { get => y; set => y = value; }

        public GameForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.Text = $"Case #{Utilities.CaseNum} - Murder Scene";
            RB_Weapon.Select();
            DrawGrid();
            scanalyzer.GenerateClue();
        }

        private void DrawGrid()
        {
            int ButtonWidth = 48;
            int ButtonHeight = 48;
            int start_x = 88;
            int start_y = 200;
            
            Button[,] tmpButton = new Button[x, y];

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

        private void BTN_Grid_Click(object sender, EventArgs e)
        {
            string[] coords = ((Button)sender).Tag.ToString().Split(',');
            int x = Int32.Parse(coords[0]);
            int y = Int32.Parse(coords[1]);

            MessageBox.Show($"You clicked on:\nX: {x} Y: {y}");
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
