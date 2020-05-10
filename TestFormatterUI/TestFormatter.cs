using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormatterUI
{
    public partial class TestFormatter : Form
    {
        private const string folder = @".\Topics";

        //private int qNum = 1;
        private Dictionary<string, int> QuestionTracking = new Dictionary<string, int>();
        private string lastTopic;

        public TestFormatter()
        {
            Directory.CreateDirectory(folder);
            InitializeComponent();
        }

        private bool isRequiredFilled()
        {
            if (
                (tb_header.Text != "") &&
                (tb_question.Text != "") &&
                (tb_ans1.Text != "") &&
                (tb_ans2.Text != "") &&
                (tb_ans3.Text != "") &&
                (tb_ans4.Text != "") 
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Generate()
        {
            //store last topic
            lastTopic = tb_topic.Text;
            if (!QuestionTracking.ContainsKey(lastTopic))
            {
                QuestionTracking[lastTopic] = 1;
            }
            l_qNumber.Text = $"Question #{QuestionTracking[lastTopic]}";

            string header = $"I: {tb_header.Text}; mt=0,1";
            string question = $"S: {tb_question.Text}";
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
            string[] result = { $"Вопрос #{QuestionTracking[lastTopic]}", header, question, ans1, ans2, ans3, ans4, "" };
            string fileName = $".\\{folder}\\{tb_topic.Text}.txt";

            //write
            File.AppendAllLines(fileName, result);

            //increase question number
            QuestionTracking[lastTopic]++;
            l_qNumber.Text = $"Question #{QuestionTracking[lastTopic]}";
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            if (tb_topic.Text != "")
            {
                if (isRequiredFilled())
                {
                    Generate();

                    tb_header.Clear();
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
            if (tb_topic.Text != "")
            {
                if (QuestionTracking.ContainsKey(tb_topic.Text))
                {
                    l_qNumber.Text = $"Question #{QuestionTracking[tb_topic.Text]}";
                }
                else
                {
                    l_qNumber.Text = "Question #--";
                }
            }
        }

        private void l_requiredFields_Click(object sender, EventArgs e)
        {

        }
    }
}
