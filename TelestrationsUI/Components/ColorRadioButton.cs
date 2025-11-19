using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelestrationsUI.Components;
public partial class ColorRadioButton : RadioButton
{
    private Rectangle _circle = new Rectangle(2, 5, 17, 17);
    private Pen _outline = new Pen(Color.Black, 1);
    public Color OnColor { get; set; } = Color.Black;
    public Color OffColor { get; set; } = Color.White;

    public ColorRadioButton() 
    {
        InitializeComponent();
    }
    public ColorRadioButton(Color onColor, Color offColor) : this()
    {
        this.OnColor = onColor;
        this.OffColor = offColor;
    }

    protected override void OnPaint(PaintEventArgs e)
    { 
        base.OnPaint(e);

        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        Color fillColor = this.Checked ? OnColor : OffColor;

        using (Brush brush = new SolidBrush(fillColor))
        {
            g.FillEllipse(brush, _circle);
        }

        g.DrawEllipse(_outline, _circle);
    }
}
