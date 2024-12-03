namespace Pachinko_SlotMachine
{
    partial class MainWindow
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
            Banner = new Panel();
            banner_Text = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Banner
            // 
            Banner.BackColor = Color.IndianRed;
            Banner.Controls.Add(banner_Text);
            Banner.Dock = DockStyle.Top;
            Banner.Location = new Point(0, 0);
            Banner.Name = "Banner";
            Banner.Size = new Size(1061, 55);
            Banner.TabIndex = 0;
            // 
            // banner_Text
            // 
            banner_Text.AutoSize = true;
            banner_Text.BackColor = Color.White;
            banner_Text.Font = new Font("Segoe UI", 13F);
            banner_Text.Location = new Point(410, 9);
            banner_Text.Name = "banner_Text";
            banner_Text.Size = new Size(229, 30);
            banner_Text.TabIndex = 0;
            banner_Text.Text = "Pachinko Slot Machine";
            banner_Text.Click += banner_Text_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(572, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(441, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(309, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(472, 157);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "BET!";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(457, 335);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 302);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 398);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Banner);
            Name = "MainWindow";
            Text = "Pachinko-SlotMachine";
            Banner.ResumeLayout(false);
            Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Banner;
        private Label banner_Text;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}
