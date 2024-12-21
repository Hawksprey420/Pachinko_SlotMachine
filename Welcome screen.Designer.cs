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
            Choose_ThemeLabel = new Label();
            themeComboBox = new ComboBox();
            startGameButton = new Button();
            SuspendLayout();
            // 
            // Choose_ThemeLabel
            // 
            Choose_ThemeLabel.AutoSize = true;
            Choose_ThemeLabel.Location = new Point(325, 178);
            Choose_ThemeLabel.Name = "Choose_ThemeLabel";
            Choose_ThemeLabel.Size = new Size(116, 20);
            Choose_ThemeLabel.TabIndex = 13;
            Choose_ThemeLabel.Text = "Choose a theme";
            // 
            // themeComboBox
            // 
            themeComboBox.FormattingEnabled = true;
            themeComboBox.Location = new Point(325, 201);
            themeComboBox.Name = "themeComboBox";
            themeComboBox.Size = new Size(151, 28);
            themeComboBox.TabIndex = 11;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(325, 244);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(151, 29);
            startGameButton.TabIndex = 12;
            startGameButton.Text = "Switch theme";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // Welcome_screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Choose_ThemeLabel);
            Controls.Add(themeComboBox);
            Controls.Add(startGameButton);
            Name = "Welcome_screen";
            Text = "Welcome_screen";
            Load += Welcome_screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Choose_ThemeLabel;
        private ComboBox themeComboBox;
        private Button startGameButton;
    }
}