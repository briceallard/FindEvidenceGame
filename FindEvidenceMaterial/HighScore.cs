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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FindEvidenceMaterial
{
    /**
     * Class Highscore (Inherited from MaterialForm)
     * 
     * Description: Contains member data for high score information including
     *      reading high score document, placing into highscore form, and
     *      writing new highscore data to document.
    **/
    public partial class HighScore : MaterialForm
    {
        // Member data
        private static string filename = "Scores.txt";
        private static string path = Path.Combine(Environment.CurrentDirectory, @"scores\", filename);

        // List holding all score data for read/write
        public static List<Score> Scores = new List<Score>();

        /**
         * Class: Score (Object structure for list)
         * 
         * @param: none
         * @return: none
         **/
        public class Score
        {
            // Member Data
            public string Initials { get; set; }
            public int Number { get; set; }

            // Parameterized Constructor
            public Score(string inits, int score)
            {
                Initials = inits;
                Number = score;
            }
        }

        /**
         * Initialize HighScore form
         * 
         * @param: none
         * @return: none
         **/
        public HighScore()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        /**
         * On Form Load event handler to initialize score data
         * 
         * @param: sender (Object Form)
         * @return: none
         **/
        private void HS_Load(object sender, EventArgs e)
        {
            // Gather scores from .txt file
            ReadScores();

            int i = 0;
            foreach (var score in Scores)
            {
                // Locate appropriate labels for placing scores based on label names
                var InitLabel = this.Controls.OfType<Label>().Where(lbl => lbl.Name == $"LBL_init{i}").FirstOrDefault();
                var ScoreLabel = this.Controls.OfType<Label>().Where(lbl => lbl.Name == $"LBL_score{i}").FirstOrDefault();
                InitLabel.Text = score.Initials;
                ScoreLabel.Text = score.Number.ToString();
                i++;
            }
        }

        /**
         * Function to read scores from .txt highscore document
         * 
         * Format: Document format must be maintained as
         *          initials=score
         *          initials=score
         *          initials=score
         *          
         * @param: none
         * @return: none
         **/
        private static void ReadScores()
        {
            // While document is open
            using (StreamReader streamReader = new StreamReader(path))
            {
                // While not EOF
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();
                    string[] lines = line.Split('=');

                    Score score = new Score(lines[0], Int32.Parse(lines[1].ToString()));
                    Scores.Add(score);
                }
            }
            
            // Sort scores by second value (score) instead of initials
            Scores.Sort(delegate (Score x, Score y) { return y.Number.CompareTo(x.Number); });

            // Re-write score data in order
            WriteScores();
        }

        /**
         * Function that writes the scores located within the List Scores
         * 
         * @param: none
         * @return: none
         **/
        private static void WriteScores()
        {
            // while document is open
            using (TextWriter textWriter = new StreamWriter(path))
            {
                // each element located within the Scores list
                foreach (var item in Scores)
                {
                    textWriter.WriteLine($"{item.Initials}={item.Number.ToString()}");
                }
            }

            // Guarantee there are no duplicates in HighScore.txt
            DeleteDuplicates();
        }

        /**
         * Guarentees no write errors by deleting all duplicate entries
         * 
         * @param: none
         * @return: none
         **/
        private static void DeleteDuplicates()
        {
            // Open files
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            FileStream writer = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            StreamReader streamReader = new StreamReader(reader);
            TextWriter textWriter = new StreamWriter(writer);

            // Generate Hash for comparisons
            HashSet<string> previousLines = new HashSet<string>();
            string currentline;

            while ((currentline = streamReader.ReadLine()) != null)
            {
                if (previousLines.Add(currentline))
                {
                    textWriter.WriteLine(currentline);
                }
            }

            // Close all open documents
            reader.Close();
            writer.Close();
            streamReader.Close();
        }

        /**
         * Button click even to exit form
         * 
         * @param: sender (Button)
         * @return: none
         **/
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            // Return to WelcomeForm
            this.Close();
        }
    }
}
