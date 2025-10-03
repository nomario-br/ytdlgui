namespace ytdlgui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("JetBrainsMono NF", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(762, 159);
            richTextBox1.TabIndex = 0;
            richTextBox1.Tag = "Youtube url";
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(664, 320);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "show console";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 371);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(749, 23);
            progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 63);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 3;
            label1.Text = "insert youtube url here";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 320);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 769);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "ytdlgui";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private ProgressBar progressBar1;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private Label label2;
    }
}
