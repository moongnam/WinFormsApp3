namespace WinFormsApp3
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(532, 376);
            button1.Name = "button1";
            button1.Size = new Size(179, 42);
            button1.TabIndex = 0;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.ham;
            pictureBox1.Location = new Point(75, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 259);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("맑은 고딕", 20F);
            textBox2.Location = new Point(356, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 43);
            textBox2.TabIndex = 3;
            textBox2.Text = "김민서";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 275);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 6;
            label1.Text = "010-9163-1868";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 230);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 7;
            label2.Text = "kms060111@suwon.ac.kr";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("맑은 고딕", 12F);
            label3.Location = new Point(356, 181);
            label3.Name = "label3";
            label3.Size = new Size(300, 21);
            label3.TabIndex = 8;
            label3.Text = "수원대학교 컴퓨터SW 25017014 김민서";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
