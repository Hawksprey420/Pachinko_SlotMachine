namespace Pachinko_SlotMachine
{
    partial class Welcome_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_screen));
            themeComboBox = new ComboBox();
            startGameButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // themeComboBox
            // 
            themeComboBox.FormattingEnabled = true;
            themeComboBox.Location = new Point(194, 22);
            themeComboBox.Name = "themeComboBox";
            themeComboBox.Size = new Size(423, 28);
            themeComboBox.TabIndex = 11;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(194, 56);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(423, 29);
            startGameButton.TabIndex = 12;
            startGameButton.Text = "Switch theme";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Algerian", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(459, 41);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO PACHINKO!!!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(themeComboBox);
            panel2.Controls.Add(startGameButton);
            panel2.Location = new Point(0, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 105);
            panel2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Algerian", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(194, 291);
            label2.Name = "label2";
            label2.Size = new Size(423, 41);
            label2.TabIndex = 16;
            label2.Text = "SELECT A GAME THEME";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Welcome_screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Welcome_screen";
            Text = "Welcome_screen";
            Load += Welcome_screen_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox themeComboBox;
        private Button startGameButton;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}