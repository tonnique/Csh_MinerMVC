using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Miner_MVC.View.util
{
    abstract class MinerViewValues
    {
        public const int cellSize = 25;
        public const int minerFieldPanel_offset = 10;

        public static SolidBrush COLOR_UNCHECKED = new SolidBrush(Color.FromArgb(181, 230, 29));
        public static SolidBrush COLOR_OPENED = new SolidBrush(Color.FromArgb(231, 235, 165));
        public static SolidBrush COLOR_MINED = new SolidBrush(Color.FromArgb(255, 0, 0));

        public static SolidBrush[] colors = new SolidBrush[]{
            COLOR_OPENED,            
            (SolidBrush) Brushes.Blue,
            new SolidBrush(Color.FromArgb(0, 100, 0)),
            (SolidBrush) Brushes.Red,
            new SolidBrush(Color.FromArgb(0, 0, 150)),
            new SolidBrush(Color.FromArgb(170, 0, 20)),
            new SolidBrush(Color.FromArgb(0, 150, 170)),
            (SolidBrush) Brushes.Black,
            (SolidBrush) Brushes.Gray
        };
    }
}
