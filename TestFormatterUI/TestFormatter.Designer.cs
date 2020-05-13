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
            this.cb_question = new System.Windows.Forms.GroupBox();
            this.l_statistics = new System.Windows.Forms.Label();
            this.l_qc4 = new System.Windows.Forms.Label();
            this.rb_ans4 = new System.Windows.Forms.RadioButton();
            this.b_generate = new System.Windows.Forms.Button();
            this.l_qc3 = new System.Windows.Forms.Label();
            this.l_qc2 = new System.Windows.Forms.Label();
            this.rb_ans3 = new System.Windows.Forms.RadioButton();
            this.rb_ans2 = new System.Windows.Forms.RadioButton();
            this.l_qc1 = new System.Windows.Forms.Label();
            this.rb_ans1 = new System.Windows.Forms.RadioButton();
            this.tb_ans3 = new System.Windows.Forms.TextBox();
            this.tb_ans4 = new System.Windows.Forms.TextBox();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_ans2 = new System.Windows.Forms.TextBox();
            this.tb_ans1 = new System.Windows.Forms.TextBox();
            this.l_subtopic = new System.Windows.Forms.Label();
            this.tb_topic = new System.Windows.Forms.TextBox();
            this.l_topic = new System.Windows.Forms.Label();
            this.tb_subtopic = new System.Windows.Forms.TextBox();
            this.l_exists = new System.Windows.Forms.Label();
            this.b_open = new System.Windows.Forms.Button();
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.cb_question.SuspendLayout();
            this.gb_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_question
            // 
            this.cb_question.Controls.Add(this.l_statistics);
            this.cb_question.Controls.Add(this.l_qc4);
            this.cb_question.Controls.Add(this.rb_ans4);
            this.cb_question.Controls.Add(this.b_generate);
            this.cb_question.Controls.Add(this.l_qc3);
            this.cb_question.Controls.Add(this.l_qc2);
            this.cb_question.Controls.Add(this.rb_ans3);
            this.cb_question.Controls.Add(this.rb_ans2);
            this.cb_question.Controls.Add(this.l_qc1);
            this.cb_question.Controls.Add(this.rb_ans1);
            this.cb_question.Controls.Add(this.tb_ans3);
            this.cb_question.Controls.Add(this.tb_ans4);
            this.cb_question.Controls.Add(this.tb_question);
            this.cb_question.Controls.Add(this.tb_ans2);
            this.cb_question.Controls.Add(this.tb_ans1);
            this.cb_question.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_question.Location = new System.Drawing.Point(0, 125);
            this.cb_question.Name = "cb_question";
            this.cb_question.Size = new System.Drawing.Size(760, 262);
            this.cb_question.TabIndex = 0;
            this.cb_question.TabStop = false;
            this.cb_question.Text = "Question #--";
            this.cb_question.Visible = false;
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
            // l_qc4
            // 
            this.l_qc4.AutoSize = true;
            this.l_qc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_qc4.Location = new System.Drawing.Point(478, 224);
            this.l_qc4.Name = "l_qc4";
            this.l_qc4.Size = new System.Drawing.Size(44, 20);
            this.l_qc4.TabIndex = 24;
            this.l_qc4.Text = "#4: 0";
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
            // l_qc3
            // 
            this.l_qc3.AutoSize = true;
            this.l_qc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_qc3.Location = new System.Drawing.Point(406, 224);
            this.l_qc3.Name = "l_qc3";
            this.l_qc3.Size = new System.Drawing.Size(44, 20);
            this.l_qc3.TabIndex = 23;
            this.l_qc3.Text = "#3: 0";
            // 
            // l_qc2
            // 
            this.l_qc2.AutoSize = true;
            this.l_qc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_qc2.Location = new System.Drawing.Point(342, 224);
            this.l_qc2.Name = "l_qc2";
            this.l_qc2.Size = new System.Drawing.Size(44, 20);
            this.l_qc2.TabIndex = 22;
            this.l_qc2.Text = "#2: 0";
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
            // l_qc1
            // 
            this.l_qc1.AutoSize = true;
            this.l_qc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_qc1.Location = new System.Drawing.Point(279, 224);
            this.l_qc1.Name = "l_qc1";
            this.l_qc1.Size = new System.Drawing.Size(44, 20);
            this.l_qc1.TabIndex = 21;
            this.l_qc1.Text = "#1: 0";
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
            // tb_ans3
            // 
            this.tb_ans3.Enabled = false;
            this.tb_ans3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans3.Location = new System.Drawing.Point(26, 138);
            this.tb_ans3.Name = "tb_ans3";
            this.tb_ans3.Size = new System.Drawing.Size(723, 27);
            this.tb_ans3.TabIndex = 3;
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
            // tb_question
            // 
            this.tb_question.Enabled = false;
            this.tb_question.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_question.Location = new System.Drawing.Point(6, 25);
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(743, 27);
            this.tb_question.TabIndex = 0;
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
            // tb_ans1
            // 
            this.tb_ans1.Enabled = false;
            this.tb_ans1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans1.Location = new System.Drawing.Point(26, 62);
            this.tb_ans1.Name = "tb_ans1";
            this.tb_ans1.Size = new System.Drawing.Size(723, 27);
            this.tb_ans1.TabIndex = 1;
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
            this.l_exists.AutoSize = true;
            this.l_exists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_exists.Location = new System.Drawing.Point(545, 35);
            this.l_exists.Name = "l_exists";
            this.l_exists.Size = new System.Drawing.Size(106, 20);
            this.l_exists.TabIndex = 19;
            this.l_exists.Text = "File exists: No";
            // 
            // b_open
            // 
            this.b_open.Enabled = false;
            this.b_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_open.Location = new System.Drawing.Point(655, 32);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(92, 27);
            this.b_open.TabIndex = 20;
            this.b_open.Text = "Open file";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Visible = false;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // gb_header
            // 
            this.gb_header.Controls.Add(this.tb_topic);
            this.gb_header.Controls.Add(this.b_open);
            this.gb_header.Controls.Add(this.l_topic);
            this.gb_header.Controls.Add(this.l_exists);
            this.gb_header.Controls.Add(this.l_subtopic);
            this.gb_header.Controls.Add(this.tb_subtopic);
            this.gb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_header.Location = new System.Drawing.Point(0, 0);
            this.gb_header.Name = "gb_header";
            this.gb_header.Size = new System.Drawing.Size(760, 122);
            this.gb_header.TabIndex = 21;
            this.gb_header.TabStop = false;
            // 
            // TestFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(760, 387);
            this.Controls.Add(this.gb_header);
            this.Controls.Add(this.cb_question);
            this.Name = "TestFormatter";
            this.Text = "TestFormatter";
            this.Click += new System.EventHandler(this.TestFormatter_Click);
            this.cb_question.ResumeLayout(false);
            this.cb_question.PerformLayout();
            this.gb_header.ResumeLayout(false);
            this.gb_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_question;
        private System.Windows.Forms.RadioButton rb_ans4;
        private System.Windows.Forms.RadioButton rb_ans3;
        private System.Windows.Forms.RadioButton rb_ans2;
        private System.Windows.Forms.RadioButton rb_ans1;
        private System.Windows.Forms.TextBox tb_ans3;
        private System.Windows.Forms.TextBox tb_ans4;
        private System.Windows.Forms.TextBox tb_ans2;
        private System.Windows.Forms.TextBox tb_ans1;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label l_subtopic;
        private System.Windows.Forms.Button b_generate;
        private System.Windows.Forms.TextBox tb_topic;
        private System.Windows.Forms.Label l_topic;
        private System.Windows.Forms.TextBox tb_subtopic;
        private System.Windows.Forms.Label l_exists;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.GroupBox gb_header;
        private System.Windows.Forms.Label l_qc1;
        private System.Windows.Forms.Label l_qc4;
        private System.Windows.Forms.Label l_qc3;
        private System.Windows.Forms.Label l_qc2;
        private System.Windows.Forms.Label l_statistics;
    }
}