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

        public TestFormatter()
        {
            Directory.CreateDirectory(folder);
            InitializeComponent();
        }

        private void Generate()
        {
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
            string[] result = { header, question, ans1, ans2, ans3, ans4, "" };
            string fileName = $".\\{folder}\\{tb_topic.Text}.txt";

            //write
            File.AppendAllLines(fileName, result);
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            if (tb_topic.Text != "")
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
            {
                MessageBox.Show("Fill the topic", "Topic", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
