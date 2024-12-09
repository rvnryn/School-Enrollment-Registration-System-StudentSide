using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


public class RoundedPictureBox : PictureBox
{
    public int CornerRadius { get; set; } = 40; // Default corner radius

    protected override void OnPaint(PaintEventArgs pe)
    {
        // Create a GraphicsPath to define the rounded rectangle
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Top-left corner
        path.AddArc(this.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Top-right corner
        path.AddArc(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Bottom-right corner
        path.AddArc(0, this.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Bottom-left corner
        path.CloseFigure();

        // Set the region of the PictureBox to the rounded rectangle
        this.Region = new Region(path);

        // Call the base class OnPaint method
        base.OnPaint(pe);
    }

    protected override void OnResize(EventArgs e)
    {
        // Invalidate the PictureBox to redraw it when resized
        this.Invalidate();
        base.OnResize(e);
    }
}



