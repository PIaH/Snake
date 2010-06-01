using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

class Snake_Body : UserControl, ISnakeSection 
{
    // Member
    private SnakeSectionType m_type;
    private Point m_position;
    private Direction m_direction;

    // C'tor
    public Snake_Body() 
        : this(
        new Point(0, 0),
        Direction.North)
    {
    }

    public Snake_Body(Point position,Direction direction)
    {
        this.m_position = position;
        this.m_type = SnakeSectionType.Body;
        this.m_direction = direction;
        this.Size = SnakeConsts.SectionSize;
        this.Location = new Point(position.X * Width, position.Y * Height);
    }

    // Public Interface
    public void Draw(PaintEventArgs e)
    {
        Console.WriteLine("Drawing at {0}:{1}", this.Position.X, this.Position.Y);

        Single delta_x = this.Location.X;
        Single delta_y = this.Location.Y;

        e.Graphics.TranslateTransform(delta_x, delta_y);
        

        switch (this.m_direction)
        {
            case Direction.East:
                {
                    Double y_d = Width * 0.4;
                    Double h_d = Width * 0.6;
                    Int32 y = Convert.ToInt32(y_d);
                    Int32 h = Convert.ToInt32(h_d);
                    Rectangle r = new Rectangle(0, y, Width, h-y);

                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(0, y), new Point(Width, y));
                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(0, h), new Point(Width, h));
                    e.Graphics.FillRectangle(SnakeConsts.BodyBrush, r);
                    break;
                }
            case Direction.West:
                {
                    Double y_d = Height * 0.4;
                    Double h_d = Height * 0.6;
                    Int32 y = Convert.ToInt32(y_d);
                    Int32 h = Convert.ToInt32(h_d);
                    Rectangle r = new Rectangle(0, y, Width, h - y);

                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(0, y), new Point(Width, y));
                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(0, h), new Point(Width, h));
                    e.Graphics.FillRectangle(SnakeConsts.BodyBrush, r);
                    break;
                }

            case Direction.North:
                {
                    Double x_d = Width * 0.4;
                    Double w_d = Width * 0.6;
                    Int32 x = Convert.ToInt32(x_d);
                    Int32 w = Convert.ToInt32(w_d);
                    Rectangle r = new Rectangle(x, 0, w-x, Height);

                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(x, 0), new Point(x, Height));
                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(w, 0), new Point(w, Height));
                    e.Graphics.FillRectangle(SnakeConsts.BodyBrush, r);
                    break;
                }
            case Direction.South:
                {
                    Double x_d = Width * 0.4;
                    Double w_d = Width * 0.6;
                    Int32 x = Convert.ToInt32(x_d);
                    Int32 w = Convert.ToInt32(w_d);
                    Rectangle r = new Rectangle(0, x, w-x, Height);
                    
                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(x, 0), new Point(x, Height));
                    e.Graphics.DrawLine(SnakeConsts.OutLinePen, new Point(w, 0), new Point(w, Height));
                    e.Graphics.FillRectangle(SnakeConsts.BodyBrush, r);
                    break;
                }
            default:
                {
                    break;
                }
        }

        e.Graphics.DrawRectangle(Pens.Red, this.ClientRectangle);
        e.Graphics.ResetTransform();
    }

    // Properties
    public Point Position
    {
        get { return this.m_position; }
        set { this.m_position = value; }
    }

    public SnakeSectionType Type
    {
        get { return this.m_type; }
        set { this.m_type = value; }
    }

    public Direction Direction
    {
        get { return this.m_direction; }
        set { this.m_direction = value; }
    }

    // Overrides
    protected override void OnPaint(PaintEventArgs e)
    {
        this.Draw(e);
    }
}