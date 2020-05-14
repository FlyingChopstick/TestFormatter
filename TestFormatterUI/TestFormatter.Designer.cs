namespace TestFormatterUI
{
    partial class TestFormatter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_subtopic = new System.Windows.Forms.Label();
            this.tb_topic = new System.Windows.Forms.TextBox();
            this.l_topic = new System.Windows.Forms.Label();
            this.tb_subtopic = new System.Windows.Forms.TextBox();
            this.l_exists = new System.Windows.Forms.Label();
            this.b_open = new System.Windows.Forms.Button();
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ans1 = new System.Windows.Forms.TextBox();
            this.tb_ans2 = new System.Windows.Forms.TextBox();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_ans4 = new System.Windows.Forms.TextBox();
            this.tb_ans3 = new System.Windows.Forms.TextBox();
            this.rb_ans1 = new System.Windows.Forms.RadioButton();
            this.rb_ans2 = new System.Windows.Forms.RadioButton();
            this.rb_ans3 = new System.Windows.Forms.RadioButton();
            this.b_generate = new System.Windows.Forms.Button();
            this.rb_ans4 = new System.Windows.Forms.RadioButton();
            this.l_statistics = new System.Windows.Forms.Label();
            this.gb_question = new System.Windows.Forms.GroupBox();
            this.b_lang = new System.Windows.Forms.Button();
            this.gb_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_question.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_subtopic
            // 
            this.l_subtopic.AutoSize = true;
            this.l_subtopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_subtopic.Location = new System.Drawing.Point(6, 62);
            this.l_subtopic.Name = "l_subtopic";
            this.l_subtopic.Size = new System.Drawing.Size(72, 20);
            this.l_subtopic.TabIndex = 10;
            this.l_subtopic.Text = "Subtopic";
            this.l_subtopic.Visible = false;
            // 
            // tb_topic
            // 
            this.tb_topic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_topic.Location = new System.Drawing.Point(6, 32);
            this.tb_topic.Name = "tb_topic";
            this.tb_topic.Size = new System.Drawing.Size(533, 27);
            this.tb_topic.TabIndex = 0;
            this.tb_topic.TextChanged += new System.EventHandler(this.tb_topic_TextChanged);
            // 
            // l_topic
            // 
            this.l_topic.AutoSize = true;
            this.l_topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_topic.Location = new System.Drawing.Point(6, 9);
            this.l_topic.Name = "l_topic";
            this.l_topic.Size = new System.Drawing.Size(47, 20);
            this.l_topic.TabIndex = 15;
            this.l_topic.Text = "Topic";
            // 
            // tb_subtopic
            // 
            this.tb_subtopic.Enabled = false;
            this.tb_subtopic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_subtopic.Location = new System.Drawing.Point(6, 85);
            this.tb_subtopic.Name = "tb_subtopic";
            this.tb_subtopic.Size = new System.Drawing.Size(743, 27);
            this.tb_subtopic.TabIndex = 1;
            this.tb_subtopic.Visible = false;
            // 
            // l_exists
            // 
            this.l_exists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_exists.Enabled = false;
            this.l_exists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_exists.Location = new System.Drawing.Point(0, 0);
            this.l_exists.Name = "l_exists";
            this.l_exists.Size = new System.Drawing.Size(229, 57);
            this.l_exists.TabIndex = 19;
            this.l_exists.Text = "File exists: No";
            this.l_exists.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_exists.Visible = false;
            // 
            // b_open
            // 
            this.b_open.AutoSize = true;
            this.b_open.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_open.Enabled = false;
            this.b_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_open.Location = new System.Drawing.Point(0, 27);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(229, 30);
            this.b_open.TabIndex = 20;
            this.b_open.Text = "Открыть файл";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Visible = false;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // gb_header
            // 
            this.gb_header.Controls.Add(this.b_lang);
            this.gb_header.Controls.Add(this.panel1);
            this.gb_header.Controls.Add(this.tb_topic);
            this.gb_header.Controls.Add(this.l_topic);
            this.gb_header.Controls.Add(this.l_subtopic);
            this.gb_header.Controls.Add(this.tb_subtopic);
            this.gb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_header.Location = new System.Drawing.Point(0, 0);
            this.gb_header.Name = "gb_header";
            this.gb_header.Size = new System.Drawing.Size(784, 122);
            this.gb_header.TabIndex = 21;
            this.gb_header.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_open);
            this.panel1.Controls.Add(this.l_exists);
            this.panel1.Location = new System.Drawing.Point(545, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 57);
            this.panel1.TabIndex = 21;
            // 
            // tb_ans1
            // 
            this.tb_ans1.Enabled = false;
            this.tb_ans1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans1.Location = new System.Drawing.Point(26, 62);
            this.tb_ans1.Name = "tb_ans1";
            this.tb_ans1.Size = new System.Drawing.Size(723, 27);
            this.tb_ans1.TabIndex = 1;
            // 
            // tb_ans2
            // 
            this.tb_ans2.Enabled = false;
            this.tb_ans2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans2.Location = new System.Drawing.Point(26, 99);
            this.tb_ans2.Name = "tb_ans2";
            this.tb_ans2.Size = new System.Drawing.Size(723, 27);
            this.tb_ans2.TabIndex = 2;
            // 
            // tb_question
            // 
            this.tb_question.Enabled = false;
            this.tb_question.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_question.Location = new System.Drawing.Point(6, 25);
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(743, 27);
            this.tb_question.TabIndex = 0;
            // 
            // tb_ans4
            // 
            this.tb_ans4.Enabled = false;
            this.tb_ans4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans4.Location = new System.Drawing.Point(26, 176);
            this.tb_ans4.Name = "tb_ans4";
            this.tb_ans4.Size = new System.Drawing.Size(723, 27);
            this.tb_ans4.TabIndex = 4;
            // 
            // tb_ans3
            // 
            this.tb_ans3.Enabled = false;
            this.tb_ans3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans3.Location = new System.Drawing.Point(26, 138);
            this.tb_ans3.Name = "tb_ans3";
            this.tb_ans3.Size = new System.Drawing.Size(723, 27);
            this.tb_ans3.TabIndex = 3;
            // 
            // rb_ans1
            // 
            this.rb_ans1.AutoSize = true;
            this.rb_ans1.Checked = true;
            this.rb_ans1.Enabled = false;
            this.rb_ans1.Location = new System.Drawing.Point(6, 68);
            this.rb_ans1.Name = "rb_ans1";
            this.rb_ans1.Size = new System.Drawing.Size(14, 13);
            this.rb_ans1.TabIndex = 4;
            this.rb_ans1.TabStop = true;
            this.rb_ans1.UseVisualStyleBackColor = true;
            // 
            // rb_ans2
            // 
            this.rb_ans2.AutoSize = true;
            this.rb_ans2.Enabled = false;
            this.rb_ans2.Location = new System.Drawing.Point(6, 105);
            this.rb_ans2.Name = "rb_ans2";
            this.rb_ans2.Size = new System.Drawing.Size(14, 13);
            this.rb_ans2.TabIndex = 5;
            this.rb_ans2.UseVisualStyleBackColor = true;
            // 
            // rb_ans3
            // 
            this.rb_ans3.AutoSize = true;
            this.rb_ans3.Enabled = false;
            this.rb_ans3.Location = new System.Drawing.Point(6, 144);
            this.rb_ans3.Name = "rb_ans3";
            this.rb_ans3.Size = new System.Drawing.Size(14, 13);
            this.rb_ans3.TabIndex = 6;
            this.rb_ans3.UseVisualStyleBackColor = true;
            // 
            // b_generate
            // 
            this.b_generate.Enabled = false;
            this.b_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_generate.Location = new System.Drawing.Point(6, 217);
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(89, 35);
            this.b_generate.TabIndex = 5;
            this.b_generate.Text = "Generate";
            this.b_generate.UseVisualStyleBackColor = true;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // rb_ans4
            // 
            this.rb_ans4.AutoSize = true;
            this.rb_ans4.Enabled = false;
            this.rb_ans4.Location = new System.Drawing.Point(6, 182);
            this.rb_ans4.Name = "rb_ans4";
            this.rb_ans4.Size = new System.Drawing.Size(14, 13);
            this.rb_ans4.TabIndex = 7;
            this.rb_ans4.UseVisualStyleBackColor = true;
            // 
            // l_statistics
            // 
            this.l_statistics.AutoSize = true;
            this.l_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_statistics.Location = new System.Drawing.Point(140, 224);
            this.l_statistics.Name = "l_statistics";
            this.l_statistics.Size = new System.Drawing.Size(133, 20);
            this.l_statistics.TabIndex = 21;
            this.l_statistics.Text = "Since last launch:";
            // 
            // gb_question
            // 
            this.gb_question.Controls.Add(this.l_statistics);
            this.gb_question.Controls.Add(this.rb_ans4);
            this.gb_question.Controls.Add(this.b_generate);
            this.gb_question.Controls.Add(this.rb_ans3);
            this.gb_question.Controls.Add(this.rb_ans2);
            this.gb_question.Controls.Add(this.rb_ans1);
            this.gb_question.Controls.Add(this.tb_ans3);
            this.gb_question.Controls.Add(this.tb_ans4);
            this.gb_question.Controls.Add(this.tb_question);
            this.gb_question.Controls.Add(this.tb_ans2);
            this.gb_question.Controls.Add(this.tb_ans1);
            this.gb_question.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_question.Location = new System.Drawing.Point(0, 123);
            this.gb_question.Name = "gb_question";
            this.gb_question.Size = new System.Drawing.Size(784, 262);
            this.gb_question.TabIndex = 0;
            this.gb_question.TabStop = false;
            this.gb_question.Text = "Question #--";
            this.gb_question.Visible = false;
            // 
            // b_lang
            // 
            this.b_lang.Location = new System.Drawing.Point(59, 9);
            this.b_lang.Name = "b_lang";
            this.b_lang.Size = new System.Drawing.Size(37, 23);
            this.b_lang.TabIndex = 22;
            this.b_lang.Text = "lang";
            this.b_lang.UseVisualStyleBackColor = true;
            this.b_lang.Click += new System.EventHandler(this.b_lang_Click);
            // 
            // TestFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.gb_header);
            this.Controls.Add(this.gb_question);
            this.Name = "TestFormatter";
            this.Text = "TestFormatter";
            this.Click += new System.EventHandler(this.TestFormatter_Click);
            this.gb_header.ResumeLayout(false);
            this.gb_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_question.ResumeLayout(false);
            this.gb_question.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label l_subtopic;
        private System.Windows.Forms.TextBox tb_topic;
        private System.Windows.Forms.Label l_topic;
        private System.Windows.Forms.TextBox tb_subtopic;
        private System.Windows.Forms.Label l_exists;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.GroupBox gb_header;
        private System.Windows.Forms.TextBox tb_ans1;
        private System.Windows.Forms.TextBox tb_ans2;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.TextBox tb_ans4;
        private System.Windows.Forms.TextBox tb_ans3;
        private System.Windows.Forms.RadioButton rb_ans1;
        private System.Windows.Forms.RadioButton rb_ans2;
        private System.Windows.Forms.RadioButton rb_ans3;
        private System.Windows.Forms.Button b_generate;
        private System.Windows.Forms.RadioButton rb_ans4;
        private System.Windows.Forms.Label l_statistics;
        private System.Windows.Forms.GroupBox gb_question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_lang;
    }
}