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
        private static string SETTINGS_PATH;
        private static int MAX_X;
        private static int MAX_Y;

        public static string SettingsPath { get => SETTINGS_PATH; set => SETTINGS_PATH = @value; }
        public static int MaxX { get => MAX_X; set => MAX_X = value; }
        public static int MaxY { get => MAX_Y; set => MAX_Y = value; }

        public static void ReadSettings()
        {
            try
            {
                string[] lines = File.ReadAllLines(SETTINGS_PATH);
                MaxX = Int32.Parse(lines[0]);
                MaxY = Int32.Parse(lines[1]);
                MessageBox.Show(FILE_SUCCESS, SUCCESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(FILE_ERROR, ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
