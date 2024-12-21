using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pachinko_SlotMachine.Reel;

namespace Pachinko_SlotMachine
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;
        private readonly abstract_Theme theme;

        public Slot(int initialBalance, Reel[] reels, abstract_Theme theme)
        {
            this.balance = initialBalance;
            this.reels = reels;
            this.theme = theme;
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Stake
        {
            get { return stake; }
            set { stake = value; }
        }

        public void Spin()
        {
            // Spin each reel
            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        public int CheckResult()
        {
            int winnings = 0;

            // Check rows for matches (assumes a 3x3 grid layout)
            for (int i = 0; i < 3; i++)
            {
                if (reels[i * 3].Symbol == reels[i * 3 + 1].Symbol && reels[i * 3 + 1].Symbol == reels[i * 3 + 2].Symbol)
                {
                    winnings += stake * 5; // Win 5x stake for a row match
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (reels[i].Symbol == reels[i + 3].Symbol && reels[i + 3].Symbol == reels[i + 6].Symbol)
                {
                    winnings += stake * 5; // Win 5x stake for a column match
                }
            }

            if (reels[0].Symbol == reels[4].Symbol && reels[4].Symbol == reels[8].Symbol)
            {
                winnings += stake * 10; // Win 10x stake for a diagonal match
            }
            if (reels[2].Symbol == reels[4].Symbol && reels[4].Symbol == reels[6].Symbol)
            {
                winnings += stake * 10; // Win 10x stake for a diagonal match
            }

            return winnings;
        }

        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}
