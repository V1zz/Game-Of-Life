using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private int _resolution;
        private Graphics _graphics;
        private GameEngine _gameEngine;

        public Form1()
        {
            InitializeComponent();
        }


#region METHODS

        private void StartGame()
        {
            if ( timer1.Enabled ) return;

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;         //todo:  percentage
            nudTimer.Enabled = false;

            _resolution = (int)nudResolution.Value;
            _gameEngine = new GameEngine(rows:    pictureBox1.Height / _resolution,
                                         cols:    pictureBox1.Width / _resolution,
                                         density: (int) nudDensity.Minimum + (int) nudDensity.Maximum - (int) nudDensity.Value,
                                         timer:   (int) nudTimer.Value);

            timer1.Interval = _gameEngine.TimerStep;

            Text = $"Generation{_gameEngine.CurrentGeneration}";

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void DrawNextGeneration()
        {
            _graphics.Clear(Color.Black);

            var field = _gameEngine.GetCurrentGeneration();

            for( var x= 0; x < field.GetLength(0); x++ )
                for (var y = 0; y < field.GetLength(1); y++ )
                    if( field[x, y])
                        _graphics.FillRectangle(Brushes.Crimson, x * _resolution, y * _resolution, _resolution - 1, _resolution - 1);

            pictureBox1.Refresh();
            Text = $"Generation{_gameEngine.CurrentGeneration}";
            _gameEngine.NextGeneration();
        }

        private void StopGame()
        {
            if(!timer1.Enabled) 
                return;

            timer1.Stop();

            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
            nudTimer.Enabled = true;
        }



        #endregion


#region EVENTS

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bSTOP_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            int x, y;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    x = e.Location.X / _resolution;
                    y = e.Location.Y / _resolution;
                    _gameEngine.AddCell(x, y);
                    break;
                case MouseButtons.Right:
                    x = e.Location.X / _resolution;
                    y = e.Location.Y / _resolution;
                    _gameEngine.RemoveCell(x, y);
                    break;
            }
        }

        private void bExit_MouseClick(object sender, MouseEventArgs e)
        {
            StopGame();
            Environment.Exit(0);
        }

        #endregion
    }
}
