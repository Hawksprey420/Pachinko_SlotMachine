using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pachinko_SlotMachine
{
    public abstract class abstract_Theme
    {
        public abstract string[] Symbols { get; }
        public abstract Font Font { get; }
        public abstract Brush Color { get; }
    }

    public class FruitTheme : abstract_Theme
    {
        public override string[] Symbols => new string[] { "🍒", "🍋", "🍇", "🍉", "🍓", "🍍" };
        public override Font Font => new Font("Segoe UI Emoji", 30, FontStyle.Bold);
        public override Brush Color => Brushes.Red;
    }

    public class AnimalTheme : abstract_Theme
    {
        public override string[] Symbols => new string[] { "🐶", "🐱", "🦊", "🐼", "🐨", "🐯" };
        public override Font Font => new Font("Segoe UI Emoji", 30, FontStyle.Bold);
        public override Brush Color => Brushes.Green;
    }

    public class GemTheme : abstract_Theme
    {
        public override string[] Symbols => new string[] { "💎", "💍", "🔶", "🔸", "🔹", "💠" };
        public override Font Font => new Font("Segoe Fluent Icons", 30, FontStyle.Bold);
        public override Brush Color => Brushes.Blue;
    }
}

