using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner_MVC.Model
{
    public class Cell
    {
        public int row { get; set; }
        public int col { get; set; }
        public bool hasBomb {get; set;}
        protected CellStatus status; // это поле хранит состояние поля - открыто-закрыто-флаг-вопрос
        public int value {get; set;} // это поле хранит значение рядом стоящих мин

        public Cell(int r, int c)
        {
            this.row = r;
            this.col = c;
            status = CellStatus.Closed;
            hasBomb = false;
            value = 0;
        }

         // Метод при нажатии правой кнопки мыши устанавливает "следующее" состояние
        public void nextState()
        {
            String[] statArray = { "Closed", "Flagged", "Questioned" };

            int id = 0;
            for (int i = 0; i < statArray.Length; i++)
            {
                if (status.ToString() == statArray[i])
                {
                    id = i; break;
                }
            }

            status = (CellStatus) Enum.Parse(typeof(CellStatus), statArray[(id + 1) % statArray.Length]);         
        }

        // Метод возвращает состояние ячейки
        public CellStatus getStatus() { return status; }

        // устанавливает статус ячейки на открытая (Opened)
        public void open()
        {
            if (this.status != CellStatus.Flagged)
                status = CellStatus.Opened;
        }
    }

}
