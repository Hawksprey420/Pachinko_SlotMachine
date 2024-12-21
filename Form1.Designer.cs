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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Banner = new Panel();
            label3 = new Label();
            txtStake = new TextBox();
            label1 = new Label();
            btnSpin = new Button();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblBalance = new Label();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblResult = new Label();
            timerSpin = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            panel1 = new Panel();
            Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Banner
            // 
            Banner.BackColor = Color.Orange;
            Banner.BackgroundImage = (Image)resources.GetObject("Banner.BackgroundImage");
            Banner.Controls.Add(label3);
            Banner.Controls.Add(txtStake);
            Banner.Controls.Add(label1);
            Banner.Controls.Add(btnSpin);
            Banner.Controls.Add(pictureBox9);
            Banner.Controls.Add(pictureBox8);
            Banner.Controls.Add(lblBalance);
            Banner.Controls.Add(pictureBox7);
            Banner.Controls.Add(pictureBox3);
            Banner.Controls.Add(pictureBox1);
            Banner.Controls.Add(pictureBox6);
            Banner.Controls.Add(pictureBox5);
            Banner.Controls.Add(pictureBox2);
            Banner.Controls.Add(pictureBox4);
            Banner.Location = new Point(0, 0);
            Banner.Name = "Banner";
            Banner.Size = new Size(582, 645);
            Banner.TabIndex = 0;
            Banner.Paint += Banner_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(56, 70);
            label3.Name = "label3";
            label3.Size = new Size(474, 28);
            label3.TabIndex = 9;
            label3.Text = "For 18+ only. Minors not allowed!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStake
            // 
            txtStake.Location = new Point(27, 468);
            txtStake.Name = "txtStake";
            txtStake.Size = new Size(539, 27);
            txtStake.TabIndex = 5;
            txtStake.TextChanged += txtStake_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Small", 9F);
            label1.Location = new Point(27, 435);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 6;
            label1.Text = "Enter bet amount";
            label1.Click += label1_Click;
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(27, 513);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(539, 54);
            btnSpin.TabIndex = 4;
            btnSpin.Text = "BET!";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Location = new Point(424, 289);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(142, 83);
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Location = new Point(202, 289);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(223, 83);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Location = new Point(27, 399);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(101, 20);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "Total Balance:";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Location = new Point(27, 289);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(176, 83);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(202, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 83);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(27, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 83);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(424, 200);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(142, 83);
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(202, 200);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(223, 83);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(424, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 83);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(27, 200);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(176, 83);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.Control;
            lblResult.Location = new Point(42, 9);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(501, 41);
            lblResult.TabIndex = 8;
            lblResult.Text = "-----------------------";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += lblResult_Click;
            // 
            // timerSpin
            // 
            timerSpin.Interval = 200;
            timerSpin.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 55);
            panel1.TabIndex = 15;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 645);
            Controls.Add(panel1);
            Controls.Add(Banner);
            Name = "MainWindow";
            Text = "Pachinko-SlotMachine";
            Load += MainWindow_Load;
            Banner.ResumeLayout(false);
            Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Banner;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnSpin;
        private TextBox txtStake;
        private Label label1;
        private Label lblBalance;
        private Label lblResult;
        private System.Windows.Forms.Timer timerSpin;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
