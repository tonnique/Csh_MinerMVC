using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner_MVC.Model
{
    // levels for the game
    public enum GameLevels
    {
        Beginner, Medium, Expert, Custom
    };

    // States of the cell
    public enum CellStatus
    {
        Opened, Closed, Flagged, Questioned
    }

    public abstract class GameSettings
    {
        public const int MIN_FIELD_HEIGHT = 2;
        public const int MIN_FIELD_WIDTH = 2;

        public const int MAX_FIELD_HEIGHT = 30;
        public const int MAX_FIELD_WIDTH = 30;

        // Максимальное количество бомб не должно превышать HEIGHT * WIDTH * MAX_BOMB_RATIO
        public const double MAX_BOMB_RATIO = 0.25;

        public const int BEGINNER_MINEFIELD_HEIGHT = 10;
        public const int BEGINNER_MINEFIELD_WIDTH = 10;
        public const int BEGINNER_NUM_OF_BOMBS = 10;

        public const int MEDIUM_MINEFIELD_HEIGHT = 16;
        public const int MEDIUM_MINEFIELD_WIDTH = 16;
        public const int MEDIUM_NUM_OF_BOMBS = 40;

        public const int EXPERT_MINEFIELD_HEIGHT = 16;
        public const int EXPERT_MINEFIELD_WIDTH = 30;
        public const int EXPERT_NUM_OF_BOMBS = 99;

        public const int CUSTOM_MINEFIELD_HEIGHT = 20;
        public const int CUSTOM_MINEFIELD_WIDTH = 30;
        public const int CUSTOM_NUM_OF_BOMBS = 145;        
    }
}