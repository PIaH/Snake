using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;



enum SnakeSectionType
{
    Head,
    Tail,
    Body,
    Strawberry,
    None
}

enum Direction
{
    North,
    East,
    South,
    West
}

interface ISnakeSection
{
    Point Position
    {
        get;
        set;
    }

    SnakeSectionType Type
    {
        get;
        set;
    }

    Size Size
    {
        get;
    }

    Direction Direction
    {
        get;
        set;
    }

    void Draw(PaintEventArgs e);
}