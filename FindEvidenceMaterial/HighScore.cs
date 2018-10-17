using System;
using System.IO;
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
    public partial class HighScore : MaterialForm
    {
        public static List<Score> Scores = new List<Score>();

        public class Score
        {
            public string Initials { get; set; }
            public int Number { get; set; }
        }

        public HighScore()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public static void ReadScores()
        {
            string filename = "Scores.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"scores\", filename);

            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split('=');

                    Score score = new Score();
                    score.Initials = lines[0];
                    score.Number = Int32.Parse(lines[1]);
                    Scores.Add(score);
                }
            }
            Scores.Sort(delegate (Score x, Score y) { return y.Number.CompareTo(x.Number); });
            WriteScores();
        }

        public static void WriteScores()
        {
            string filename = "Scores.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"scores\", filename);

            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (var item in Scores)
                {
                    tw.WriteLine($"{item.Initials}={item.Number.ToString()}");
                }
            }
        }
    }
}
