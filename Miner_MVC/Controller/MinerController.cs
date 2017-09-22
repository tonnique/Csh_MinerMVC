using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Miner_MVC.Model;
using Miner_MVC.View;
using Miner_MVC.View.util;

namespace Miner_MVC.Controller
{
    class MinerController
    {
        private Model.MinerGame model;
        private View.frmSettings settings;

        public IMinerView view { get;  set; }
        public MinerController(MinerGame model)
        {
            this.model = model;
        }

        public void startNewGame()
        {
            int[] gameSettings = getGameSettings();
            model.startNewGame(gameSettings[0], gameSettings[1], gameSettings[2]);
            view.addNewMineField();            
        }

        private int[] getGameSettings()
        {
            if (settings == null)
            {
                return new int[] { 
                    GameSettings.BEGINNER_MINEFIELD_HEIGHT, 
                    GameSettings.BEGINNER_MINEFIELD_WIDTH,
                    GameSettings.BEGINNER_NUM_OF_BOMBS
                };
            }
            else
            {
                return new int[] {settings.getFieldHeight(),
                    settings.getFieldWidth(), settings.getBombsNumber()};
            }
        }

        public void minefield_Paint(object sender, PaintEventArgs e)
        {            
            view.updateMineField();
        }

        public void mni_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void mni_Settings_Click(object sender, EventArgs e) {
            processSettingsMenu();
        }

        public void btnNewGame_Click(object sender, EventArgs e) {            
            startNewGame();
        }

      
        
        public void mineField_MouseUp(object sender, MouseEventArgs e)
        {
            int row = e.Y / MinerViewValues.cellSize;
            int col = e.X / MinerViewValues.cellSize;

            if (e.Button == MouseButtons.Left) {
                LeftMouseClick(row, col);
            }
            else if (e.Button == MouseButtons.Right)
            {
                RightMouseClick(row, col);
            }
            
        }

        private void LeftMouseClick(int row, int col) {
            Cell cell = model.getCell(row, col);
            if ((cell != null) && cell.getStatus() == CellStatus.Opened ||
                cell.getStatus() == CellStatus.Flagged ||
                model.isGameOver())
                return;
            else
            {
                model.openCell(cell);
                view.updateMineField();
                if (model.isWin())
                {
                    view.showWinMessage();
                }
                else if (model.isGameOver())
                {
                    view.showGameOverMessage();
                }
            }
        }

        private void RightMouseClick(int row, int col)
        {            
            Cell cell = model.getCell(row, col);
            // cell может быть null если например пользов-ль нажимает на край поля - 
            // тогда координата col будет больше допустимого. model.getCell - проверит и вернет null
            if ((cell != null) && cell.getStatus() == CellStatus.Opened || model.isGameOver()) return;
            else
            {
                model.nextCellMark(cell);
                view.updateMineField();

                if (model.isWin())
                    view.showWinMessage();
            }
        }


        private void processSettingsMenu()
        {            
            if (settings == null)
                settings = new frmSettings();
            
            settings.ShowDialog();
            
            if (settings.isUserConfirmed())
            {
                startNewGame();
            }
        }
    }
}
