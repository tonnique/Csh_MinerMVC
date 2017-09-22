using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Miner_MVC.Model;
using Miner_MVC.View.util;

namespace Miner_MVC.View
{
    internal class CellView : Cell 
    {

        public CellView(int y, int x) : base(y, x) 
        { }

        public CellView(Cell c) : base (c.row, c.col) {
            this.hasBomb = c.hasBomb;
            this.value = c.value;
            this.status = c.getStatus();
        }

        internal void drawCell(Graphics g, int y, int x, bool gameover) {
            int cellSize = MinerViewValues.cellSize;
            int xCoord = x * cellSize;
            int yCoord = y * cellSize;
            
            Rectangle cell = new Rectangle(xCoord, yCoord, cellSize, cellSize);
            String srtCellValue = "";

            // по умолчанию рисуются закрытые ячейки
            g.FillRectangle(MinerViewValues.COLOR_UNCHECKED, cell);
            g.DrawRectangle(Pens.Black, cell);

            switch (this.getStatus())
            {
                case CellStatus.Closed:                    
                    break;
                case CellStatus.Flagged:
                    srtCellValue = "F";
                    g.DrawString(srtCellValue, new Font("Sans-Serif", 10, FontStyle.Bold), Brushes.Red, new Point(xCoord + 5, yCoord + 5));
                    if (gameover && !hasBomb) {
                        g.DrawString("X", new Font("Sans-Serif", 10, FontStyle.Bold), Brushes.Black, new Point(xCoord + 5, yCoord + 5));                    
                    }
                    break;
                case CellStatus.Questioned:                    
                    srtCellValue = "?";                    
                    g.DrawString(srtCellValue, new Font("Sans-Serif", 10, FontStyle.Bold), Brushes.Black, new Point(xCoord + 5, yCoord + 5));                    
                    break;
                case CellStatus.Opened:
                    if (!hasBomb)
                    {
                        g.FillRectangle(MinerViewValues.colors[0], cell);
                        g.DrawRectangle(Pens.Black, cell);                     

                        srtCellValue = value + "";
                        Brush brush = null;
                        switch (value)
                        {
                            case 0:
                                srtCellValue = "";
                                brush = MinerViewValues.COLOR_UNCHECKED;
                                break;
                            case 1:                               
                                brush = MinerViewValues.colors[1];
                                break;
                            case 2:                                                                
                                brush = MinerViewValues.colors[2];
                                break;
                            case 3:                                
                                brush = MinerViewValues.colors[3];
                                break;
                            case 4:                                
                                brush = MinerViewValues.colors[4];
                                break;
                            case 5:                                
                                brush = MinerViewValues.colors[5];
                                break;
                            case 6:                                
                                brush = MinerViewValues.colors[6];
                                break;
                            case 7:                                
                                brush = MinerViewValues.colors[7];
                                break;
                            case 8:                                
                                brush = MinerViewValues.colors[8];
                                break;
                        }
                        g.DrawString(srtCellValue, new Font("Sans-Serif", 10, FontStyle.Bold), brush, new Point(xCoord + 5, yCoord + 5));
                    }
                    else
                    {                        
                        g.FillRectangle(MinerViewValues.COLOR_MINED, cell);
                        g.DrawRectangle(Pens.Black, cell);
                    }
                    break;
                default:
                    return;
            }         
        }
    }
}
