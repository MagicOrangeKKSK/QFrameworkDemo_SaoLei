using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Marisa
{
    public class GameMainMineCell_OnClickedEventArgs
    {
        public GameMainMineCell Sender { get; set; }

        public int Row { get; set; }
        public int Col { get; set; }
        public int ClickType { get; set; }

        public GameMainMineCell_OnClickedEventArgs(GameMainMineCell sender, int row, int col, int clickType)
        {
            Sender = sender;
            Row = row;
            Col = col;
            ClickType = clickType;
        }
    }
}