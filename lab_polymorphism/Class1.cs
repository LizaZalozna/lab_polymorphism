using lab_polymorphism;
using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

abstract class Figure
{
	protected int xCenter;
	protected int yCenter;
    protected Form form;

    public void MoveRight()
    {
        while (xCenter < form.Width)
        {
            DrawBlack();
            Thread.Sleep(100);
            HideDrawingBackGround();
            xCenter += 5;
        }
    }

    public abstract void DrawBlack();
    public abstract void HideDrawingBackGround();
}

class Circle:Figure
{
    private int radius;

    public Circle(int xCenter, int yCenter, int radius, Form form)
    {
        this.xCenter = xCenter;
        this.yCenter = yCenter;
        this.radius = radius;
        this.form = form;
    }
    public override void DrawBlack()
    {
        Graphics graphics = form.CreateGraphics();
        graphics.DrawEllipse(Pens.Black, xCenter - radius, yCenter - radius, radius * 2, radius * 2);
    }

    public override void HideDrawingBackGround()
    {
        Graphics graphics = form.CreateGraphics();
        graphics.DrawEllipse(new Pen(form.BackColor), xCenter - radius, yCenter - radius, radius * 2, radius * 2);
    }
}
