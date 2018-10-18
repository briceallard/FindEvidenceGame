using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    public partial class HighScore : MaterialForm
    {
        public static string filename = "Scores.txt";
        public static string path = Path.Combine(Environment.CurrentDirectory, @"scores\", filename);
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
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (var item in Scores)
                {
                    tw.WriteLine($"{item.Initials}={item.Number.ToString()}");
                }
            }
        }

        private void HS_Load(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter(path))
            {
                var InitLabels = Controls.OfType<Label>().Where(label => label.Name.StartsWith("LBL_init")).ToArray();
                var ScoreLabels = Controls.OfType<Label>().Where(label => label.Name.StartsWith("LBL_score")).ToArray();

                //for (int i = 0; i < 10; i++)
                //{
                //    var inits = Scores[i].Initials;
                //    InitLabels[i].Text = inits;
                //    ScoreLabels[i].Text = Scores[i].Number.ToString();
                //}
            }
        }
    }
}
