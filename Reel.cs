using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pachinko_SlotMachine
{
    internal class Reel
    {
        public class Reels
        {
            private string symbol;
            private readonly PictureBox pictureBox;
            private readonly string[] symbols = { "🍒", "🍋", "🔔", "⭐", "🍇", "💎" };
            private readonly Random random = new Random();

            public Reels(PictureBox pictureBox)
            {
                this.pictureBox = pictureBox;
                this.pictureBox.Paint += Reels_Paint;
                this.Symbol = symbols[random.Next(symbols.Length)];
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

            private void Reels_Paint(object sender, PaintEventArgs e)
            {
                using (Font font = new Font("Segoe UI Emoji", 30, FontStyle.Bold))
                {
                    e.Graphics.DrawString(symbol, font, Brushes.Black, new PointF(10, 10));
                }
            }

            public void Spin()
            {
                // Randomly select a symbol for the reel and update it
                Symbol = symbols[random.Next(symbols.Length)];
            }
        }

    }
}
