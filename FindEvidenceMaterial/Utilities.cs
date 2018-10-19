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
        public static string SettingsPath { get; set; }
        public static bool Settings { get; set; }
        public static int MaxX { get; set; }
        public static int MaxY { get; set; }
        public static int CaseNum { get; set; }
        public static int HighScore { get; set; }

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

        public static string WIN_MESSAGE
        {
            get
            {
                return "Congratualations!\n\nYou found all the evidence in ";
            }
        }

        public static string WIN_TITLE
        {
            get
            {
                return "WINNER";
            }
        }
    }
}
