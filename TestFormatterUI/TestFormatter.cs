using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestFormatterUI
{

    public partial class TestFormatter : Form
    {
        /// <summary>
        /// Topic output folder
        /// </summary>
        private const string outputFolder = @".\Topics\";//@".\Topics\Output\";
        /// <summary>
        /// Topic output prefix
        /// </summary>
        private const string outputPrefix = "topic_";
        /// <summary>
        /// Path to active file
        /// </summary>
        private string activeFile;

        /// <summary>
        /// Tracks question count across different topics
        /// </summary>
        private Dictionary<string, int> QuestionTracking = new Dictionary<string, int>();

        private int[] statistics = { 0, 0, 0, 0, 0 };

        private Dictionary<string, int[]> TopicStats = new Dictionary<string, int[]>();

        public TestFormatter()
        {
                Directory.CreateDirectory(outputFolder);
                InitializeComponent();
        }

        /// <summary>
        /// Generates a question
        /// </summary>
        private void Generate()
        {
            //formatting
            string topic = tb_topic.Text;
            string subtopic = $"I: {tb_subtopic.Text}; mt=0,1";
            string question = $"S: {tb_question.Text}:";
            string ans1, ans2, ans3, ans4;

            if (rb_ans1.Checked)
            {
                //ans1 correct
                statistics[1]++;
                ans1 = $"+: {tb_ans1.Text}";
                ans2 = $"-: {tb_ans2.Text}";
                ans3 = $"-: {tb_ans3.Text}";
                ans4 = $"-: {tb_ans4.Text}";

                //staticstics
                if (TopicStats.ContainsKey(topic))
                {
                    TopicStats[topic][0]++;
                    TopicStats[topic][1]++;
                }
                else
                {
                    TopicStats[topic] = new int[] { 1, 1, 0, 0, 0 };
                }
            }
            else
            {
                if (rb_ans2.Checked)
                {
                    //ans2 correct
                    statistics[2]++;
                    ans1 = $"-: {tb_ans1.Text}";
                    ans2 = $"+: {tb_ans2.Text}";
                    ans3 = $"-: {tb_ans3.Text}";
                    ans4 = $"-: {tb_ans4.Text}";

                    //staticstics
                    if (TopicStats.ContainsKey(topic))
                    {
                        TopicStats[topic][0]++;
                        TopicStats[topic][2]++;
                    }
                    else
                    {
                        TopicStats[topic] = new int[] { 1, 0, 1, 0, 0 };
                    }
                }
                else
                {
                    if (rb_ans3.Checked)
                    {
                        //ans3 correct
                        statistics[3]++;
                        ans1 = $"-: {tb_ans1.Text}";
                        ans2 = $"-: {tb_ans2.Text}";
                        ans3 = $"+: {tb_ans3.Text}";
                        ans4 = $"-: {tb_ans4.Text}";

                        //staticstics
                        if (TopicStats.ContainsKey(topic))
                        {
                            TopicStats[topic][0]++;
                            TopicStats[topic][3]++;
                        }
                        else
                        {
                            TopicStats[topic] = new int[] { 1, 0, 0, 1, 0 };
                        }
                    }
                    else
                    {
                        //ans4 correct
                        statistics[4]++;
                        ans1 = $"-: {tb_ans1.Text}";
                        ans2 = $"-: {tb_ans2.Text}";
                        ans3 = $"-: {tb_ans3.Text}";
                        ans4 = $"+: {tb_ans4.Text}";

                        //staticstics
                        if (TopicStats.ContainsKey(topic))
                        {
                            TopicStats[topic][0]++;
                            TopicStats[topic][4]++;
                        }
                        else
                        {
                            TopicStats[topic] = new int[] { 1, 0, 0, 0, 1 };
                        }
                    }
                }
            }

            //compile
            string[] result = { subtopic, question, ans1, ans2, ans3, ans4, "" }; 

            //write
            File.AppendAllLines(activeFile, result);

            //gb_header.Text = TopicStats[topic][1].ToString();

            statistics[0]++;
        }
        /// <summary>
        /// Checks that input fields are filled
        /// </summary>
        /// <returns></returns>
        private bool IsRequiredFilled()
        {
            if (
                String.IsNullOrEmpty(tb_subtopic.Text) ||
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
        /// Locks or unlocks the input fields
        /// </summary>
        /// <param name="unlocked">Should the fields be unlocked</param>
        private void FieldUnlock(bool unlocked)
        {
            l_subtopic.Visible = unlocked;
            tb_subtopic.Enabled = unlocked;
            tb_subtopic.Visible = unlocked;

            cb_question.Visible = unlocked;
            tb_question.Enabled = unlocked;

            tb_ans1.Enabled = unlocked;
            rb_ans1.Enabled = unlocked;
            //rb_ans1.Checked = unlocked;

            tb_ans2.Enabled = unlocked;
            rb_ans2.Enabled = unlocked;

            tb_ans3.Enabled = unlocked;
            rb_ans3.Enabled = unlocked;

            tb_ans4.Enabled = unlocked;
            rb_ans4.Enabled = unlocked;

            b_generate.Enabled = unlocked;
        }
        /// <summary>
        /// Clears input fields
        /// </summary>
        private void ClearFields()
        {
            //statistics = { 0, 0, 0, 0, 0 };

            tb_subtopic.Text = string.Empty;
            tb_question.Text = string.Empty;
            tb_ans1.Text = string.Empty;
            tb_ans2.Text = string.Empty;
            tb_ans3.Text = string.Empty;
            tb_ans4.Text = string.Empty;
        }
        /// <summary>
        /// Updates various UI elements
        /// </summary>
        private void UpdateStats()
        {
            string topic = tb_topic.Text;
            if (topic.Length != 0)
            {
                activeFile = $"{outputFolder}{outputPrefix}{tb_topic.Text}.txt";
                ScanFile(topic);
                FieldUnlock(true);

                if (TopicStats.ContainsKey(topic))
                {
                    gb_header.Text = "!";
                    l_qc1.Text = $"#1: {TopicStats[topic][1]}";
                    l_qc2.Text = $"#2: {TopicStats[topic][2]}";
                    l_qc3.Text = $"#3: {TopicStats[topic][3]}";
                    l_qc4.Text = $"#4: {TopicStats[topic][4]}";
                }
                else
                {
                    l_qc1.Text = "#1: 0";
                    l_qc2.Text = "#2: 0";
                    l_qc3.Text = "#3: 0";
                    l_qc4.Text = "#4: 0";
                }
            }
            else
            {
                l_exists.Text = "File exists: No";
                b_open.Enabled = false;
                b_open.Visible = false;

                cb_question.Text = "Question #--";

                FieldUnlock(false);
            }        
        }
        /// <summary>
        /// Determines the existence and amount of question in the file
        /// </summary>
        /// <param name="topic">Query topic</param>
        /// <returns><see langword="true"/>if file exists, <see langword="false"/>if not</returns>
        private bool ScanFile(string topic)
        {
            if (File.Exists(activeFile))
            {
                //unlock the "open file" button
                l_exists.Text = "File exists: Yes";
                b_open.Enabled = true;
                b_open.Visible = true;

                //count question in file, assuming each is 7 lines long
                int len = File.ReadAllLines(activeFile).Length;
                int qCount = len / 7 + 1;
                QuestionTracking[topic] = qCount;

                cb_question.Text = $"Question #{QuestionTracking[topic].ToString()}";
                return true;
            }
            else
            {
                //lock the "open file" button
                l_exists.Text = "File exists: No";
                b_open.Enabled = false;
                b_open.Visible = false;

                cb_question.Text = "Question #1";
                return false;
            }
        }

        private void SelectionAssist()
        {
            List<int> pool = new List<int>()
            { 
                statistics[1] / statistics[0], 
                statistics[2] / statistics[0], 
                statistics[3] / statistics[0], 
                statistics[4] / statistics[0] 
            };


            int suggestion = pool.IndexOf(pool.Min());
            switch (suggestion)
            {
                case 0:
                    {
                        rb_ans1.Checked = true;
                        break;
                    }
                case 1:
                    {
                        rb_ans2.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rb_ans3.Checked = true;
                        break;
                    }
                case 3:
                    {
                        rb_ans4.Checked = true;
                        break;
                    }
            }
            l_qc1.Text = (suggestion+1).ToString();
        }

        //form controls
        private void b_generate_Click(object sender, EventArgs e)
        {
            if (tb_topic.Text.Length != 0)
            {
                if (IsRequiredFilled())
                {
                    Generate();
                    UpdateStats();
                    //SelectionAssist();

                    tb_question.Clear();
                    tb_ans1.Clear();
                    tb_ans2.Clear();
                    tb_ans3.Clear();
                    tb_ans4.Clear();

                    tb_question.Select();
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
        private void b_open_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(activeFile);
            }
            catch (FileNotFoundException)
            {
                UpdateStats();

                MessageBox.Show("Could not open the file. Perhaps it was deleted?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TestFormatter_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }
    }
}