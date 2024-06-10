namespace Mad_Max_Progress_Tracker
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            scavTotal = new Label();
            pictureBox2 = new PictureBox();
            campsText = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            storyMissionsText = new Label();
            wastelandMissionsText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 944);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Not Working";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.scavenginglocation;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // scavTotal
            // 
            scavTotal.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scavTotal.ForeColor = Color.Black;
            scavTotal.Location = new Point(138, 12);
            scavTotal.Name = "scavTotal";
            scavTotal.Size = new Size(204, 118);
            scavTotal.TabIndex = 2;
            scavTotal.Text = "0";
            scavTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.transfertankcamp;
            pictureBox2.Location = new Point(12, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // campsText
            // 
            campsText.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            campsText.ForeColor = Color.Black;
            campsText.Location = new Point(138, 136);
            campsText.Name = "campsText";
            campsText.Size = new Size(204, 118);
            campsText.TabIndex = 4;
            campsText.Text = "0";
            campsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.objectivemarker;
            pictureBox3.Location = new Point(12, 260);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.wastelandmission;
            pictureBox4.Location = new Point(12, 384);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 118);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // storyMissionsText
            // 
            storyMissionsText.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storyMissionsText.ForeColor = Color.Black;
            storyMissionsText.Location = new Point(138, 260);
            storyMissionsText.Name = "storyMissionsText";
            storyMissionsText.Size = new Size(204, 118);
            storyMissionsText.TabIndex = 7;
            storyMissionsText.Text = "0";
            storyMissionsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // wastelandMissionsText
            // 
            wastelandMissionsText.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wastelandMissionsText.ForeColor = Color.Black;
            wastelandMissionsText.Location = new Point(138, 384);
            wastelandMissionsText.Name = "wastelandMissionsText";
            wastelandMissionsText.Size = new Size(204, 118);
            wastelandMissionsText.TabIndex = 8;
            wastelandMissionsText.Text = "0";
            wastelandMissionsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 978);
            Controls.Add(wastelandMissionsText);
            Controls.Add(storyMissionsText);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(campsText);
            Controls.Add(pictureBox2);
            Controls.Add(scavTotal);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label scavTotal;
        private PictureBox pictureBox2;
        private Label campsText;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label storyMissionsText;
        private Label wastelandMissionsText;
    }
}
