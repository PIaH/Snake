using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeMainForm : Form
    {
        Snake_Grid m_grid;

        public SnakeMainForm()
        {
            this.m_grid = new Snake_Grid();

            this.Controls.Add(this.m_grid);
        }
    }
}
