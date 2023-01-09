using System;

namespace GameOfLife
{
    public class GameEngine
    {
        private readonly int _rows;
        private readonly int _cols;
        private bool[,] _field;

        public uint CurrentGeneration { get; private set; }
        public int TimerStep { get; private set; }
        
#region CONSTRUCTORS

        public GameEngine(int rows, int cols, int  density)
        {
            this._cols = cols;
            this._rows = rows;

            _field = new bool[cols, rows];
            var random = new Random();
            TimerStep = 40;

            for (var x = 0; x < _cols; x++)
            {
                for (var y = 0; y < _rows; y++)
                {
                    _field[x, y] = random.Next(density) == 0;
                }
            }
        }

        public GameEngine(int rows, int cols, int density, int timer) 
            : this(rows, cols, density)
        {
            this.TimerStep = timer;
        }
        
        #endregion

#region PUBLIC METHODS

        public void NextGeneration()
        {
            var newField = new bool[_cols, _rows];
        
            for (var x = 0; x < _cols; x++)
            {
                for (var y = 0; y < _rows; y++)
                {
                    var neighboursCount = CountNeighbors(x, y);
                    var hasLife = _field[x, y];
        
                    if (!hasLife && neighboursCount == 3)
                        newField[x, y] = true;
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = _field[x, y];
                }
            }
        
            _field = newField;
            CurrentGeneration++;
        }

        public bool[,] GetCurrentGeneration()
        {
            var result = new bool[_cols, _rows];

            for (var x = 0; x < _cols; x++)
                for (var y = 0; y < _rows; y++)
                    result[x, y] = _field[x, y];

            return result;
        }

        public void AddCell(int x, int y)
        {
            UpdateCell(x, y, state: true);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, state: false);
        }

        public void ClearField()
        {
            _field = GetClearField();
        }

        #endregion

#region PRIVATE METHODS

        private int CountNeighbors(int x, int y)
        {
            var count = 0;

            for (var i = -1; i < 2; i++)
            {
                for (var j = -1; j < 2; j++)
                {
                    var col = (x + i + _cols) % _cols;
                    var row = (y + j + _rows) % _rows;

                    var isSelfChecked = col == x && row == y;
                    var hasLifeAround = _field[col, row];

                    if (hasLifeAround && !isSelfChecked)
                        count++;
                }
            }
            
            return count;
        }

        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < _cols && y < _rows;
        }
        
        private void UpdateCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y)) 
                _field[x, y] = state;
        }

        private bool[,] GetClearField()
        {
            var result = new bool[_cols, _rows];

            for (var x = 0; x < _cols; x++)
            for (var y = 0; y < _rows; y++)
                result[x, y] = false;

            return result;
        }
        
        #endregion

    }
}