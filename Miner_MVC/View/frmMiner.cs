using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Miner_MVC.Controller;
using Miner_MVC.Model;
using Miner_MVC.View.util;

namespace Miner_MVC.View 
{
    public partial class frmMiner : Form, IMinerView
    {
        MinerGame model;
        MinerController controller;
        Graphics g;
        //Size frmSize;

        public frmMiner()
        {
            model = new MinerGame();
            controller = new MinerController(model);
            controller.view = this;
            
            InitializeComponent();

            //this.Paint += new PaintEventHandler(controller.minefield_Paint);
            
            mineField.Paint += new PaintEventHandler(controller.minefield_Paint);
            mineField.MouseUp += new System.Windows.Forms.MouseEventHandler(controller.mineField_MouseUp);

            btnNewGame.Click += new EventHandler(controller.btnNewGame_Click);
            mni_NewGame.Click += new EventHandler(controller.btnNewGame_Click);
            mni_Exit.Click += new EventHandler(controller.mni_Exit_Click);
            mniSettings.Click += new EventHandler(controller.mni_Settings_Click);  
            controller.startNewGame();         
        }   

        // добавить новое игровое поле на основе данных Модели
        public void addNewMineField()
        {   
            // меняем размер окна
            int cellsize = MinerViewValues.cellSize;
            int height = model.getHeight();
            int width = model.getWidth();

            this.Width = width * cellsize + MinerViewValues.minerFieldPanel_offset;            
            this.Height = height * cellsize + MinerViewValues.minerFieldPanel_offset +
                mnuStrip1.Height + toolStrip1.Height + stsStrip1.Height+20;

            Refresh();
     
            // размещаем кнопку по центру ширины окна
            btnNewGame.Location = new Point((this.Width - btnNewGame.Width) / 2, btnNewGame.Location.Y);
            this.CenterToScreen();
            this.Activate();
        }

        public void showWinMessage()
        {
            MessageBox.Show("Вы выиграли!");
        }

        public void showGameOverMessage()
        {
            MessageBox.Show("Бум! Вы проиграли.");
        }

        public void updateMineField()
        {
            lblStatus.Text = model.getBombsNumber() + " Mines";
            int height = model.getHeight();
            int width = model.getWidth();
                    
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {   
                    using (g = mineField.CreateGraphics()) {

                        CellView tmpCell = new CellView(model.getCell(row, col));                   
                        tmpCell.drawCell(g, row, col, model.isGameOver());
                    }
                }
            }
        }        
    }
}
