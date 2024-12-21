using System;
using System.Drawing;
using System.Windows.Forms;
using Pachinko_SlotMachine;
using static Pachinko_SlotMachine.Reel;
using static Pachinko_SlotMachine.Slot;

namespace Pachinko_SlotMachine
{
    public partial class MainWindow : Form
    {
        private Slot slotMachine;
        public MainWindow(abstract_Theme theme)
        {
            InitializeComponent();
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            InitializeSlotMachine(pictureBoxes, theme);
        }

        private void InitializeSlotMachine(PictureBox[] pictureBoxes, abstract_Theme theme)
        {
            // Create Reel objects for each PictureBox using the selected theme
            Reel[] reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], theme);
            }

            // Initialize SlotMachine object with a starting balance of 1000
            slotMachine = new Slot(1000, reels, theme);

            // Update the balance label on the form
            lblBalance.Text = $"Balance: P{slotMachine.Balance}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void banner_Text_Click(object sender, EventArgs e)
        {

        }

        private void Banner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Get the stake from the input box
            if (int.TryParse(s: txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {

                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false; 	// Disable the button during spin
                lblResult.Text = "";  	// Clear any previous result
                timerSpin.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slotMachine.Spin();			// Spin the reels

            if (DateTime.Now.Second % 2 == 0) 	// Stop spinning after 2 seconds
            {
                timerSpin.Stop();
                btnSpin.Enabled = true;

                int winnings = slotMachine.CheckResult();	// Check the result and update the UI accordingly

                slotMachine.UpdateBalance(winnings);

                // Update the result label
                if (winnings > 0)
                {
                    lblResult.Text = "WIN! You earned P" + winnings + " ??";
                    lblResult.ForeColor = Color.YellowGreen;
                }
                else
                {
                    lblResult.Text = "No luck this time!";
                    lblResult.ForeColor = Color.Red;
                }

                lblBalance.Text = "Balance: P" + slotMachine.Balance;
                txtStake.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStake_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
