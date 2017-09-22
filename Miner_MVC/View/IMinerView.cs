using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miner_MVC.View
{
    interface IMinerView
    {
        /**
         * Add new minefiled onto the view control in cases when the game is just started
         * or user has restarted the game
         */
        void addNewMineField();

        void showWinMessage();

        void showGameOverMessage();

        void updateMineField();

    }

}
