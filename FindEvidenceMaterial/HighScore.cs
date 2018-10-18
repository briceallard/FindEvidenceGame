using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    public partial class HighScore : MaterialForm
    {
        private static string filename = "Scores.txt";
        private static string path = Path.Combine(Environment.CurrentDirectory, @"scores\", filename);
        public static List<Score> Scores = new List<Score>();

        public class Score
        {
            public string Initials { get; set; }
            public int Number { get; set; }

            public Score(string inits, int score)
            {
                Initials = inits;
                Number = score;
            }
        }

        public HighScore()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void HS_Load(object sender, EventArgs e)
        {
            ReadScores();

            int i = 0;
            foreach (var score in Scores)
            {
                var InitLabel = this.Controls.OfType<Label>().Where(lbl => lbl.Name == $"LBL_init{i}").FirstOrDefault();
                var ScoreLabel = this.Controls.OfType<Label>().Where(lbl => lbl.Name == $"LBL_score{i}").FirstOrDefault();
                InitLabel.Text = score.Initials;
                ScoreLabel.Text = score.Number.ToString();
                i++;
            }
        }

        private static void ReadScores()
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();
                    string[] lines = line.Split('=');

                    Score score = new Score(lines[0], Int32.Parse(lines[1].ToString()));
                    Scores.Add(score);
                }
            }
            Scores.Sort(delegate (Score x, Score y) { return y.Number.CompareTo(x.Number); });

            WriteScores();
        }

        private static void WriteScores()
        {
            using (TextWriter textWriter = new StreamWriter(path))
            {
                foreach (var item in Scores)
                {
                    textWriter.WriteLine($"{item.Initials}={item.Number.ToString()}");
                }
            }
            DeleteDuplicates();
        }

        private static void DeleteDuplicates()
        {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            FileStream writer = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            StreamReader streamReader = new StreamReader(reader);
            TextWriter textWriter = new StreamWriter(writer);

            string currentline;
            HashSet<string> previousLines = new HashSet<string>();

            while ((currentline = streamReader.ReadLine()) != null)
            {
                if (previousLines.Add(currentline))
                {
                    textWriter.WriteLine(currentline);
                }
            }
            reader.Close();
            writer.Close();
            streamReader.Close();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
