using System;
using System.Threading;
using System.Windows.Forms;

abstract class Figure
{
	private int xCenter;
	private int yCenter;
    private Form form;

    public void MoveRight()
    {
        while (xCenter < form.Width)
        {
            DrawBlack();
            Thread.Sleep(100);
            HideDrawingBackGround();
            xCenter += 10;
        }
    }

    public abstract void DrawBlack();
    public abstract void HideDrawingBackGround();
}
