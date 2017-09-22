using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Miner_MVC.Model;


namespace Miner_MVC.View
{
    public partial class frmSettings : Form
    {
        // нажал ли пользователь ОК при работе с окном
        private bool userConfirmed = false;

        private int minefield_height;
        private int minefield_width;
        private int bomb_number;

        private RadioButton selectedRB;
        private RadioButton oldSelectedRB;

        public frmSettings()
        {
            InitializeComponent();

            selectedRB = radBtn1;
            oldSelectedRB = selectedRB;
        }

        public int getFieldWidth() { return minefield_width; }

        public int getFieldHeight() { return minefield_height; }

        public int getBombsNumber() { return bomb_number; }

        public bool isUserConfirmed() { return userConfirmed; }

        private void processOKButton()
        {
            userConfirmed = true;

            setLevel(selectedRB.Text);
            oldSelectedRB = selectedRB;
        }

        private void processCancelButton()
        {
            userConfirmed = false;
            oldSelectedRB.Checked = true;
            selectedRB = oldSelectedRB;
        }

       /**
       * Определяем уровень сложности -
       * задаем параметры размеров поля и кол-во мин
       */
        private void setLevel(String text)
        {
            switch (text)
            {
                case "Новичок":
                    minefield_height = GameSettings.BEGINNER_MINEFIELD_HEIGHT;
                    minefield_width = GameSettings.BEGINNER_MINEFIELD_WIDTH;
                    bomb_number = GameSettings.BEGINNER_NUM_OF_BOMBS;
                    break;
                case "Бывалый":
                    minefield_height = GameSettings.MEDIUM_MINEFIELD_HEIGHT;
                    minefield_width = GameSettings.MEDIUM_MINEFIELD_WIDTH;
                    bomb_number = GameSettings.MEDIUM_NUM_OF_BOMBS;
                    break;
                case "Эксперт":
                    minefield_height = GameSettings.EXPERT_MINEFIELD_HEIGHT;
                    minefield_width = GameSettings.EXPERT_MINEFIELD_WIDTH;
                    bomb_number = GameSettings.EXPERT_NUM_OF_BOMBS;
                    break;
                case "Особый":
                    try
                    {
                        minefield_height = Int32.Parse(txtHeight.Text);
                        minefield_width = Int32.Parse(txtWidth.Text);
                        bomb_number = Int32.Parse(txtBombs.Text);
                    } catch (Exception) { 
                        MessageBox.Show("Внимание! Вы ввели не правильные данные");
                    }
                    break;

                default:
                    minefield_height = GameSettings.BEGINNER_MINEFIELD_HEIGHT;
                    minefield_width = GameSettings.BEGINNER_MINEFIELD_WIDTH;
                    bomb_number = GameSettings.BEGINNER_NUM_OF_BOMBS;
                    break;
            }
        }

        private void radBtn_CheckedChanged(object sender, EventArgs e)
        {            
            RadioButton button = (RadioButton) sender;
            selectedRB = button;
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            radBtn4.Checked = true;
            radBtn4.PerformClick();            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Button srcButton = (Button)sender;

            if (srcButton == btnOK)
            {
                processOKButton();
            }
            else
            {
                processCancelButton();
            }

            this.Hide();
        }
    }
}
