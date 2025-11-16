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

namespace TelestrationsUI.Forms;
public partial class frmZoomPaint : Form
{
    private float rotationAngle = 0.0f;
    private float zoomFactor = 1.0f;
    private float zoomStep = .05f;

    private RectangleF imageRect = RectangleF.Empty;
    private PointF imageLocation = PointF.Empty;
    private PointF mouseLocation = PointF.Empty;

    private Bitmap drawingImage = null;
    private PictureBoxEx canvas = null;
    private ZoomMode zoomMode = ZoomMode.MouseOffset;

    private enum ZoomMode
    {
        ImageLocation,
        CenterCanvas,
        CenterMouse,
        MouseOffset
    }

    public frmZoomPaint()
    {
        InitializeComponent();
        string imagePath = "C:\\Users\\chand\\Downloads\\unnamed.png";
        drawingImage = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(imagePath)));
        imageRect = new RectangleF(Point.Empty, drawingImage.Size);

        canvas = new PictureBoxEx(new Size(555, 300));
        canvas.Location = new Point(10, 10);
        canvas.MouseWheel += canvas_MouseWheel;
        canvas.MouseMove += canvas_MouseMove;
        canvas.MouseDown += canvas_MouseDown;
        canvas.MouseUp += canvas_MouseUp;
        canvas.Paint += canvas_Paint;
        Controls.Add(canvas);
    }

    private void canvas_MouseWheel(object sender, MouseEventArgs e)
    {
        mouseLocation = e.Location;
        float zoomCurrent = zoomFactor;
        zoomFactor += e.Delta > 0 ? zoomStep : -zoomStep;
        if (zoomFactor < .10f) zoomStep = .01f;
        if (zoomFactor >= .10f) zoomStep = .05f;
        if (zoomFactor < .0f) zoomFactor = zoomStep;

        switch (zoomMode)
        {
            case ZoomMode.CenterCanvas:
                imageRect = CenterScaledRectangleOnCanvas(imageRect, canvas.ClientRectangle);
                break;
            case ZoomMode.CenterMouse:
                imageRect = CenterScaledRectangleOnMousePosition(imageRect, e.Location);
                break;
            case ZoomMode.MouseOffset:
                imageRect = OffsetScaledRectangleOnMousePosition(imageRect, zoomCurrent, e.Location);
                break;
            default:
                break;
        }

        canvas.Invalidate();
    }

    private void canvas_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        mouseLocation = e.Location;
        imageLocation = imageRect.Location;
        canvas.Cursor = Cursors.NoMove2D;
    }

    private void canvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        imageRect.Location =
            new PointF(imageLocation.X + (e.Location.X - mouseLocation.X),
                       imageLocation.Y + (e.Location.Y - mouseLocation.Y));
        canvas.Invalidate();
    }

    private void canvas_MouseUp(object sender, MouseEventArgs e) =>
        canvas.Cursor = Cursors.Default;

    private void canvas_Paint(object sender, PaintEventArgs e)
    {
        var drawingRect = GetDrawingImageRect(imageRect);

        using (var mxRotation = new Matrix())
        using (var mxTransform = new Matrix())
        {

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            mxRotation.RotateAt(rotationAngle, GetDrawingImageCenterPoint(drawingRect));
            mxTransform.Multiply(mxRotation);

            e.Graphics.Transform = mxTransform;
            e.Graphics.DrawImage(drawingImage, drawingRect);
        }
    }

    private void trkRotationAngle_ValueChanged(object sender, EventArgs e)
    {
        rotationAngle = trkAngle.Value;
        canvas.Invalidate();
        canvas.Focus();
    }

    private void radZoom_CheckedChanged(object sender, EventArgs e)
    {
        var rad = sender as RadioButton;
        if (rad.Checked)
        {
            zoomMode = (ZoomMode)int.Parse(rad.Tag.ToString());
        }
        canvas.Focus();
    }

    #region Drawing Methods

    public RectangleF GetScaledRect(RectangleF rect, float scaleFactor) =>
        new RectangleF(rect.Location,
        new SizeF(rect.Width * scaleFactor, rect.Height * scaleFactor));

    public RectangleF GetDrawingImageRect(RectangleF rect) =>
        GetScaledRect(rect, zoomFactor);

    public PointF GetDrawingImageCenterPoint(RectangleF rect) =>
        new PointF(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);

    public RectangleF CenterScaledRectangleOnCanvas(RectangleF rect, RectangleF canvas)
    {
        var scaled = GetScaledRect(rect, zoomFactor);
        rect.Location = new PointF((canvas.Width - scaled.Width) / 2,
                                   (canvas.Height - scaled.Height) / 2);
        return rect;
    }

    public RectangleF CenterScaledRectangleOnMousePosition(RectangleF rect, PointF mousePosition)
    {
        var scaled = GetScaledRect(rect, zoomFactor);
        rect.Location = new PointF(mousePosition.X - (scaled.Width / 2),
                                   mousePosition.Y - (scaled.Height / 2));
        return rect;
    }

    public RectangleF OffsetScaledRectangleOnMousePosition(RectangleF rect, float currentZoom, PointF mousePosition)
    {
        var currentRect = GetScaledRect(imageRect, currentZoom);
        if (!currentRect.Contains(mousePosition)) return rect;

        float scaleRatio = currentRect.Width / GetScaledRect(rect, zoomFactor).Width;

        PointF mouseOffset = new PointF(mousePosition.X - rect.X, mousePosition.Y - rect.Y);
        PointF scaledOffset = new PointF(mouseOffset.X / scaleRatio, mouseOffset.Y / scaleRatio);
        PointF position = new PointF(rect.X - (scaledOffset.X - mouseOffset.X),
                                     rect.Y - (scaledOffset.Y - mouseOffset.Y));
        rect.Location = position;
        return rect;
    }

    #endregion
}
