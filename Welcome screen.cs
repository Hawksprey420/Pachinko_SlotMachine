using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pachinko_SlotMachine
{
    public partial class Welcome_screen : Form
    {
        public Welcome_screen()
        {
            InitializeComponent();
            themeComboBox.Items.AddRange(new string[] { "Fruit", "Animals", "Gems" });
            themeComboBox.SelectedIndex = 0;
        }

        private void Welcome_screen_Load(object sender, EventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (themeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a theme!");
                return;
            }

            string selectedTheme = themeComboBox.SelectedItem.ToString();
            abstract_Theme theme = selectedTheme switch
            {
                "Fruits" => new FruitTheme(),
                "Animals" => new AnimalTheme(),
                "Gems" => new GemTheme(),
                _ => new FruitTheme(),
            };

            MainWindow mainWindow = new MainWindow(theme);
            mainWindow.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
