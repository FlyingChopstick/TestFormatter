using FormatterController;
using System;
using System.IO;
using System.Windows.Forms;

namespace TestFormatterUI
{

    public partial class TestFormatter : Form
    {
        public TestFormatter()
        {
            InitializeComponent();

            Controller.Setup();
            ReloadNames();
        }


        /// <summary>
        /// Generates a question
        /// </summary>
        private void Generate()
        {
            Question newQuestion;

            //formatting
            newQuestion.Filename = tb_topic.Text;
            newQuestion.Theme = tb_subtopic.Text;//$"I: {tb_subtopic.Text}; mt=0,1";
            newQuestion.QuestionText = tb_question.Text;//$"S: {tb_question.Text}:";
            //string ans1, ans2, ans3, ans4;

            if (rb_ans1.Checked)
            {
                //ans1 correct
                //statistics[1]++;
                newQuestion.Correct = QNum.First;
                newQuestion.ans1 = tb_ans1.Text;//$"+: {tb_ans1.Text}";
                newQuestion.ans2 = tb_ans2.Text;//$"-: {tb_ans2.Text}";
                newQuestion.ans3 = tb_ans3.Text;//$"-: {tb_ans3.Text}";
                newQuestion.ans4 = tb_ans4.Text;//$"-: {tb_ans4.Text}";

                //staticstics
                //if (TopicStats.ContainsKey(topic))
                //{
                //    TopicStats[topic][0]++;
                //    TopicStats[topic][1]++;
                //}
                //else
                //{
                //    TopicStats[topic] = new int[] { 1, 1, 0, 0, 0 };
                //}
            }
            else
            {
                if (rb_ans2.Checked)
                {
                    //ans2 correct
                    //statistics[2]++;
                    newQuestion.Correct = QNum.Second;
                    newQuestion.ans1 = tb_ans1.Text;//$"-: {tb_ans1.Text}";
                    newQuestion.ans2 = tb_ans2.Text;//$"+: {tb_ans2.Text}";
                    newQuestion.ans3 = tb_ans3.Text;//$"-: {tb_ans3.Text}";
                    newQuestion.ans4 = tb_ans4.Text;//$"-: {tb_ans4.Text}";

                    //staticstics
                    //if (TopicStats.ContainsKey(topic))
                    //{
                    //    TopicStats[topic][0]++;
                    //    TopicStats[topic][2]++;
                    //}
                    //else
                    //{
                    //    TopicStats[topic] = new int[] { 1, 0, 1, 0, 0 };
                    //}
                }
                else
                {
                    if (rb_ans3.Checked)
                    {
                        //ans3 correct
                        //statistics[3]++;
                        newQuestion.Correct = QNum.Third;
                        newQuestion.ans1 = tb_ans1.Text;//$"-: {tb_ans1.Text}";
                        newQuestion.ans2 = tb_ans2.Text;//$"-: {tb_ans2.Text}";
                        newQuestion.ans3 = tb_ans3.Text;//$"+: {tb_ans3.Text}";
                        newQuestion.ans4 = tb_ans4.Text;//$"-: {tb_ans4.Text}";

                        //staticstics
                        //if (TopicStats.ContainsKey(topic))
                        //{
                        //    TopicStats[topic][0]++;
                        //    TopicStats[topic][3]++;
                        //}
                        //else
                        //{
                        //    TopicStats[topic] = new int[] { 1, 0, 0, 1, 0 };
                        //}
                    }
                    else
                    {
                        //newQuestion.ans4 correct
                        //statistics[4]++;
                        newQuestion.Correct = QNum.Fourth;
                        newQuestion.ans1 = tb_ans1.Text;//$"-: {tb_ans1.Text}";
                        newQuestion.ans2 = tb_ans2.Text;//$"-: {tb_ans2.Text}";
                        newQuestion.ans3 = tb_ans3.Text;//$"-: {tb_ans3.Text}";
                        newQuestion.ans4 = tb_ans4.Text;//$"+: {tb_ans4.Text}";

                        //staticstics
                        //if (TopicStats.ContainsKey(topic))
                        //{
                        //    TopicStats[topic][0]++;
                        //    TopicStats[topic][4]++;
                        //}
                        //else
                        //{
                        //    TopicStats[topic] = new int[] { 1, 0, 0, 0, 1 };
                        //}
                    }
                }
            }

            //compile
            //string[] result = { subtopic, question, ans1, ans2, ans3, ans4, "" };

            //write
            //File.AppendAllLines(activeFile, result);

            //statistics[0]++;
            Controller.Write(newQuestion);
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
            l_qTopic.Visible = unlocked;
            tb_subtopic.Enabled = unlocked;
            tb_subtopic.Visible = unlocked;

            l_exists.Enabled = unlocked;
            l_exists.Visible = unlocked;

            gb_question.Visible = unlocked;
            tb_question.Enabled = unlocked;

            tb_ans1.Enabled = unlocked;
            rb_ans1.Enabled = unlocked;

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
                Controller.SetActiveFile(topic);
                if (Controller.ScanFile(topic))
                {
                    FileButtonLock(topic);
                }
                FieldUnlock(true);
                l_statistics.Text = Controller.FormatStats(topic);
                gb_question.Text = Controller.GetQuestionNumber(topic);
            }
            else
            {
                l_exists.Text = Controller.CLoca.L_fileExistsN;
                b_open.Enabled = false;
                b_open.Visible = false;

                gb_question.Text = string.Format(Controller.CLoca.GB_question, "--");

                FieldUnlock(false);
            }
        }
        /// <summary>
        /// Determines the existence and amount of question in the file
        /// </summary>
        /// <param name="topic">Query topic</param>
        /// <returns><see langword="true"/>if file exists, <see langword="false"/>if not</returns>
        private void FileButtonLock(string topic)
        {
            if (Controller.ScanFile(topic))
            {
                //unlock the "open file" button
                l_exists.Text = Controller.CLoca.L_fileExistsY;
                b_open.Enabled = true;
                b_open.Visible = true;
            }
            else
            {
                //lock the "open file" button
                l_exists.Text = Controller.CLoca.L_fileExistsN;
                b_open.Enabled = false;
                b_open.Visible = false;
            }
        }


        #region Form Controls
        private void b_generate_Click(object sender, EventArgs e)
        {
            if (tb_topic.Text.Length != 0)
            {
                if (IsRequiredFilled())
                {
                    Generate();
                    UpdateStats();

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
                Controller.OpenActiveFile();
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
        private void b_lang_Click(object sender, EventArgs e)
        {
            SwitchLang();
            ReloadNames();
        }
        #endregion

        #region Language
        /// <summary>
        /// Reloads localization
        /// </summary>
        private void ReloadNames()
        {
            string topic = tb_topic.Text;
            FileButtonLock(topic);

            l_filename.Text = Controller.CLoca.L_filename;
            l_qTopic.Text = Controller.CLoca.L_qTopic;
            l_exists.Text = Controller.CLoca.L_fileExistsN;

            b_open.Text = Controller.CLoca.B_openFile;
            b_generate.Text = Controller.CLoca.B_generate;

            UpdateStats();
        }
        private void SwitchLang()
        {
            switch (Controller.CLang)
            {
                case "English":
                    {
                        Controller.SetLocalization("Russian");
                        break;
                    }
                case "Russian":
                    {
                        Controller.SetLocalization("English");
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException("Language not recognized");
                    }
            }
        }
        #endregion
    }
}