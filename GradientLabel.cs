using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientLabel : Label
{
    public Color StartColor { get; set; } = Color.Red;
    public Color EndColor { get; set; } = Color.Blue;
    public GradientLabel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent; // Устанавливаем прозрачный фон
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, StartColor, EndColor, LinearGradientMode.Horizontal))
        {
            e.Graphics.DrawString(Text, Font, brush, ClientRectangle);
        }
    }
}
