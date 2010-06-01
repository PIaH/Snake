using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

class Snake_Grid : UserControl
{
    // Member
    private ISnakeSection[,] m_grid;

    // C'tor
    public Snake_Grid() 
    {
        this.m_grid = new ISnakeSection[SnakeConsts.GridSize.Width,SnakeConsts.GridSize.Height];
        for (int i = 0; i < this.m_grid.GetLength(0); i++)
        {
            for (int j = 0; j < this.m_grid.GetLength(1); j++)
            {
                this.m_grid[i, j] = new Snake_Body(new Point(i, j), Direction.North);
            }
        }

        Size wholesize = new Size(SnakeConsts.GridSize.Width * SnakeConsts.SectionSize.Width,
            SnakeConsts.GridSize.Height * SnakeConsts.SectionSize.Height);
        this.Size = wholesize;
    }


    // Overrides
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.FillRectangle(Brushes.DarkMagenta, this.ClientRectangle);
        
        for (int i = 0; i < this.m_grid.GetLength(0); i++)
        {
            for (int j = 0; j < this.m_grid.GetLength(1); j++)
            {
                this.m_grid[i, j].Draw(e);
            }
        }
    }
}