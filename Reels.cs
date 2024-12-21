using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pachinko_SlotMachine;

namespace Pachinko_SlotMachine
{
    public class Reel
    {
        //private readonly string[] symbols = { "🍒", "🍋", "🔔", "⭐", "🍇", "💎" };
        private string symbol;
        private readonly PictureBox pictureBox;
        private static readonly Random random = new Random();
        private readonly abstract_Theme theme;

        public Reel(PictureBox pictureBox, abstract_Theme theme)
        {
            this.pictureBox = pictureBox;
            this.theme = theme;
            this.pictureBox.Paint += Reel_Paint;
            this.Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];
        }


        public string Symbol
        {
            get => symbol;
            set
            {
                symbol = value;
                pictureBox.Invalidate(); // Trigger repaint to update the display
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            using (Font font = new Font("Segoe UI Emoji", 30, FontStyle.Bold))
            {
                e.Graphics.DrawString(symbol, font, Brushes.Black, new PointF(10, 10));
            }
        }

        public void Spin()
        {
            // Randomly select a symbol for the reel and update it
            Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];
        }
    }

}
