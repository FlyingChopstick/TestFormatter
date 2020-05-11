using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace TestFormatterUI
{

    public partial class TestFormatter : Form
    {
        /// <summary>
        /// Save pack
        /// </summary>
        [Serializable]
        internal struct State
        {
            /// <summary>
            /// Creates a save pack
            /// </summary>
            /// <param name="inQT">Tracker to save</param>
            public State(Dictionary<string, int> inQT)
            {
                QuestionTracking = inQT;
            }
            public Dictionary<string, int> QuestionTracking;
        }

        /// <summary>
        /// Topic output folder
        /// </summary>
        private const string outputFolder = @".\Topics\Outptut\";
        /// <summary>
        /// State save folder
        /// </summary>
        private const string saveFolder = @".\Topics\";
        /// <summary>
        /// State save name
        /// </summary>
        private const string saveName = @"lastState";
        /// <summary>
        /// State save path
        /// </summary>
        string saveFilePath;

        /// <summary>
        /// Tracks question count across different topics
        /// </summary>
        private Dictionary<string, int> QuestionTracking = new Dictionary<string, int>();
        /// <summary>
        /// Stores last topic
        /// </summary>
        private string lastTopic;

        public TestFormatter()
        {

            Directory.CreateDirectory(outputFolder);
            InitializeComponent();

            saveFilePath = $"{saveFolder}{saveName}";
            RestoreState();
        }

        /// <summary>
        /// Checks if the required fields are filled
        /// </summary>
        /// <returns></returns>
        private bool IsRequiredFilled()
        {
            if (
                String.IsNullOrEmpty(tb_header.Text) ||
                String.IsNullOrEmpty(tb_question.Text) ||
                String.IsNullOrEmpty(tb_ans1.Text) ||
                String.IsNullOrEmpty(tb_ans2.Text) ||
                String.IsNullOrEmpty(tb_ans3.Text) ||
                String.IsNullOrEmpty(tb_ans4.Text)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Generates a question
        /// </summary>
        private void Generate()
        {
            //store topic
            string topic = tb_topic.Text;

            //lastTopic = tb_topic.Text;
            //if (!QuestionTracking.ContainsKey(lastTopic))
            //{
            //    QuestionTracking[lastTopic] = 1;
            //}
            //tb_qNumber.Text = QuestionTracking[lastTopic].ToString();

            string header = $"I: {tb_header.Text}; mt=0,1";
            string question = $"S: {tb_question.Text}:";
            string ans1, ans2, ans3, ans4;

            //ans1
            if (rb_ans1.Checked)
            {
                ans1 = $"+: {tb_ans1.Text}";
            }
            else
            {
                ans1 = $"-: {tb_ans1.Text}";
            }

            //ans2
            if (rb_ans2.Checked)
            {
                ans2 = $"+: {tb_ans2.Text}";
            }
            else
            {
                ans2 = $"-: {tb_ans2.Text}";
            }

            //ans3
            if (rb_ans3.Checked)
            {
                ans3 = $"+: {tb_ans3.Text}";
            }
            else
            {
                ans3 = $"-: {tb_ans3.Text}";
            }

            //ans4
            if (rb_ans4.Checked)
            {
                ans4 = $"+: {tb_ans4.Text}";
            }
            else
            {
                ans4 = $"-: {tb_ans4.Text}";
            }

            //compile
            string[] result = { header, question, ans1, ans2, ans3, ans4, "" };
            string fileName = $"{outputFolder}{tb_topic.Text}.txt";

            //write
            File.AppendAllLines(fileName, result);

            //increase question number
            QuestionTracking[topic]++;
            tb_qNumber.Text = QuestionTracking[topic].ToString();
        }

        /// <summary>
        /// Saves QuestionTracking
        /// </summary>
        private void SaveState()
        {
            CleanTracker();

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            try
            {
                if (File.Exists(saveFilePath))
                {
                    File.SetAttributes(saveFilePath, FileAttributes.Normal);
                }

                using (StreamWriter saveStream = new StreamWriter(saveFilePath))
                {
                    using (JsonWriter writer = new JsonTextWriter(saveStream))
                    {
                        serializer.Serialize(writer, new State(QuestionTracking));
                    }
                }

                File.SetAttributes(saveFilePath, FileAttributes.Hidden);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save state tracking", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Restores QuestionTracking
        /// </summary>
        private void RestoreState()
        {
            if (File.Exists(saveFilePath))
            {
                try
                {
                    State loadedState = JsonConvert.DeserializeObject<State>(File.ReadAllText(saveFilePath));
                    QuestionTracking = loadedState.QuestionTracking;
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not save restore tracking", "Restore failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CleanTracker();
            }
        }

        private void FieldLock(bool locked)
        {
            tb_qNumber.ReadOnly = locked;
            tb_header.ReadOnly = locked;
            tb_question.ReadOnly = locked;
            tb_ans1.ReadOnly = locked;
            tb_ans2.ReadOnly = locked;
            tb_ans3.ReadOnly = locked;
            tb_ans4.ReadOnly = locked;
        }
        private void ClearFields()
        {
            tb_header.Text = string.Empty;
            tb_question.Text = string.Empty;
            tb_ans1.Text = string.Empty;
            tb_ans2.Text = string.Empty;
            tb_ans3.Text = string.Empty;
            tb_ans4.Text = string.Empty;
        }
        private void UpdateStats()
        {
            string topic = tb_topic.Text;
            if (topic.Length != 0)
            {
                if (CheckExists())//File.Exists($"{outputFolder}\\{topic}.txt"))//QuestionTracking.ContainsKey(tb_topic.Text))
                {
                    l_exists.Text = "File exists: Yes";
                    b_open.Enabled = true;
                    b_open.Visible = true;

                    int len = File.ReadAllLines($"{outputFolder}{topic}.txt").Length;
                    int qCount = len / 7 + 1;

                    tb_qNumber.Text = qCount.ToString();
                }
                else
                {
                    l_exists.Text = "File exists: No";
                    tb_qNumber.Text = "1";

                    b_open.Enabled = false;
                    b_open.Visible = false;
                }

                FieldLock(false);
            }
            else
            {
                tb_qNumber.Text = "--";

                FieldLock(true);
            }
        }
        private bool CheckExists()
        {
            if (File.Exists($"{outputFolder}{tb_topic.Text}.txt"))
                return true;
            else 
                return false;
        }


        /// <summary>
        /// Removes non-existent topics from QuestionTracking
        /// </summary>
        private void CleanTracker()
        {
            string[] files = Directory.GetFiles(outputFolder).Where(File => File.Contains(".txt")).ToArray();
            string[] topics = QuestionTracking.Keys.ToArray();

            for (int i = 0; i < QuestionTracking.Keys.Count; i++)
            {
                string topic = $"{outputFolder}{topics[i]}.txt";
                if (!files.Contains(topic))
                {
                    QuestionTracking.Remove(topics[i]);
                }
            }
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            if (tb_topic.Text != "")
            {
                if (IsRequiredFilled())
                {
                    Generate();

                    tb_question.Clear();
                    tb_ans1.Clear();
                    tb_ans2.Clear();
                    tb_ans3.Clear();
                    tb_ans4.Clear();
                }
                else
                    MessageBox.Show("Fill all fields", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Fill the topic", "Topic", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_topic_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
            UpdateStats();
        }

        private void tb_qNumber_TextChanged(object sender, EventArgs e)
        {
            if (tb_topic.Text.Length != 0)
            {
                if ((tb_qNumber.Text != "--") || (tb_qNumber.Text.Length != 0))
                {
                    QuestionTracking[tb_topic.Text] = Convert.ToInt32(tb_qNumber.Text);
                }
                UpdateStats();
            }
        }

        private void TestFormatter_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveState();
        }
        /// <summary>
        /// Opens the .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_open_Click(object sender, EventArgs e)
        {
            string topic = tb_topic.Text;
            string topicFile = $"{outputFolder}{topic}.txt";
            System.Diagnostics.Process.Start(topicFile);
        }

        private void TestFormatter_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }
    }
}
