using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelestrationsUI.Components;
public partial class ColorRadioButton : RadioButton
{
    private int _borderThickness = 5;
    private Color _selectedBorderColor { get; set; } = Color.DodgerBlue;
    private Color _borderColor = Color.LightGray;
    private int _circleSize = 18;

    public Color CircleColor { get; set; } = Color.Black;

    public ColorRadioButton()
    {
        this.Size = new Size(28, 28);
        this.Text = "";
        this.BackColor = Color.Transparent;

        SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw |
            ControlStyles.SupportsTransparentBackColor,
            true
        );
    }

    public override Size GetPreferredSize(Size proposedSize)
    {
        return new Size(28, 28);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // clear background
        if (Parent != null)
            g.Clear(Parent.BackColor);

        int padding = 5;
        Rectangle rect = new Rectangle(
            padding,
            padding,
            _circleSize,
            _circleSize
        );

        using (SolidBrush b = new SolidBrush(CircleColor))
            g.FillEllipse(b, rect);

        using (Pen borderPen = new Pen(_borderColor, 1.5f))
            g.DrawEllipse(borderPen, rect);

        if (this.Checked)
        {
            using (Pen selPen = new Pen(_selectedBorderColor, _borderThickness))
                g.DrawEllipse(selPen, rect);
        }
    }
}
