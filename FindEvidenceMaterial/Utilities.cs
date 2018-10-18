using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvidenceMaterial
{
    class Utilities
    {
        public static List<Score> Scores = new List<Score>();

        public static string SettingsPath { get; set; }
        public static bool Settings { get; set; }
        public static int MaxX { get; set; }
        public static int MaxY { get; set; }
        public static int CaseNum { get; set; }

        public class Score
        {
            public string Initials { get; set; }
            public int Number { get; set; }
        }

        public static void ReadSettings()
        {
            try
            {
                string[] lines = File.ReadAllLines(SettingsPath);
                MaxX = Int32.Parse(lines[0]);
                MaxY = Int32.Parse(lines[1]);
                CaseNum = Int32.Parse(lines[2]) + 1;
                lines[2] = CaseNum.ToString();
                File.WriteAllLines(SettingsPath, lines);
                Settings = true;
                MessageBox.Show(FILE_SUCCESS, SUCCESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(FILE_ERROR, ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReadScores()
        {

            using (StreamReader sr = new StreamReader(Properties.Resources.Scores))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split('=');

                    Score score = new Score();
                    score.Initials = lines[0];
                    score.Number = Int32.Parse(lines[1]);
                    Scores.Add(score);
                    Scores.Sort();
                }
            }


        }

        public static 

        public static int GenerateRandom(int min, int max)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int rand = random.Next(min, max);

            return rand;
        }

        public static string FILE_ERROR
        {
            get
            {
                return "File Not Found";
            }
        }

        public static string NOFILE_ERROR
        {
            get
            {
                return "No File Selected";
            }
        }

        public static string FILE_SUCCESS
        {
            get
            {
                return "File Uploaded";
            }
        }

        public static string ERROR_TITLE
        {
            get
            {
                return "ERROR";
            }
        }

        public static string SUCCESS_TITLE
        {
            get
            {
                return "SUCCESS";
            }
        }

        public static string FOUND_MESSAGE
        {
            get
            {
                return "Clue Found!";
            }
        }

        public static string FOUND_TITLE
        {
            get
            {
                return "FOUND";
            }
        }
    }
}
