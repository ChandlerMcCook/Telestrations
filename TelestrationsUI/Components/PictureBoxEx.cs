// Source - https://stackoverflow.com/a
// Posted by Jimi, modified by community. See post 'Timeline' for change history
// Retrieved 2025-11-15, License - CC BY-SA 4.0

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

[DesignerCategory("Code")]
public class PictureBoxEx : PictureBox
{
    public PictureBoxEx() : this(new Size(200, 200)) { }
    public PictureBoxEx(Size size)
    {
        SetStyle(ControlStyles.Selectable | ControlStyles.UserMouse, true);
        BorderStyle = BorderStyle.FixedSingle;
        Size = size;
    }
}
