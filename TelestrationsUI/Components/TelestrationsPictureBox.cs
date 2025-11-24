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
using TelestrationsLibrary;
using TelestrationsUI.UIObjects;
using static TelestrationsLibrary.Globals;

namespace TelestrationsUI.Components;
public partial class TelestrationsPictureBox : PictureBox
{
    private Bitmap _image;

    // drawing
    private bool _isDrawing = false;
    private Point _lastPoint = Point.Empty;

    // zoom
    private RectangleF _imageRect = new RectangleF(
        Point.Empty,
        new Size(Globals.CANVAS_SIZE_X, Globals.CANVAS_SIZE_Y)
    );
    private PointF _panMouseLocation = PointF.Empty; // holds a beginning mouse location for when the user pans the screen
    private PointF _imageLocation = PointF.Empty; // holds a beginning image location for when the user pans the screen
    private float _zoomFactor = 1.0f;
    private float _zoomStep = .15f;

    // selection
    private RectangleF _selectionRect = new RectangleF();
    private Brush _selectionBrush = new SolidBrush(Color.Gray);

    public Pen TelePen { get; set; } = new Pen(Color.Black, 1);
    public Color CurrentColor
    {
        get { return TelePen.Color; }
        set { TelePen.Color = value; }
    }
    public ImageHistory CanvasImageHistory { get; set; }
    public DrawingMode DrawMode { get; set; } = DrawingMode.Draw;
    public Cursor TeleCursor
    {
        get { return this.Cursor; }
        set { this.Cursor = value; }
    }
    public bool SmoothMode { get; set; } = false;

    public TelestrationsPictureBox() : this(new Size(100, 100)) { }
    public TelestrationsPictureBox(Size size)
    {
        InitializeComponent();

        this.SetStyle(ControlStyles.UserMouse, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        _image = new Bitmap(Globals.CANVAS_SIZE_X, Globals.CANVAS_SIZE_Y);
        using (Graphics g = Graphics.FromImage(_image))
        {
            g.Clear(Color.White);
        }
        CanvasImageHistory = new ImageHistory(_image);

        TelePen.StartCap = LineCap.Round;
        TelePen.EndCap = LineCap.Round;
        TelePen.LineJoin = LineJoin.Round;
    }

    public void ClearCanvas()
    {
        _image = new Bitmap(Globals.CANVAS_SIZE_X, Globals.CANVAS_SIZE_Y);
        using (Graphics g = Graphics.FromImage(_image))
        {
            g.Clear(Color.White);
        }
        CanvasImageHistory.AddImage(_image);
        this.Invalidate();
    }

    public void SetCanvas(Bitmap picture)
    {
        _image = picture;
        this.Invalidate();
    }

    public Bitmap GetCanvas()
    {
        return _image;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        switch (e.Button)
        {
            case MouseButtons.Left:
                if (DrawMode == DrawingMode.Draw)
                {
                    _isDrawing = true;
                    _lastPoint = e.Location;
                }
                else
                {
                    PointF zoomCoords = ScreenToImage(e.Location);
                    FloodFill.FloodFillBitmap(_image, new Point((int)zoomCoords.X, (int)zoomCoords.Y), TelePen.Color);
                }
                break;
            case MouseButtons.Right:
            case MouseButtons.Middle:
                if (_zoomFactor >= 1f) // only pan when zoomed in
                {
                    _panMouseLocation = e.Location;
                    _imageLocation = _imageRect.Location;
                    this.Cursor = Cursors.NoMove2D;
                }
                break;
                //_isDrawing = false;
                //_lastPoint = e.Location;
                //break;
        }

        return;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);

        switch (e.Button)
        {
            case MouseButtons.Left:
                _isDrawing = false;
                CanvasImageHistory.AddImage(_image);
                break;
            case MouseButtons.Right:
            case MouseButtons.Middle:
                this.Cursor = TeleCursor;
                break;
        }

        return;
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        this.Cursor = TeleCursor;
        _isDrawing = false;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);

        switch (e.Button)
        {
            case MouseButtons.Left:
                if (_isDrawing)
                {
                    float radius = TelePen.Width / 2f;
                    PointF lastImagePoint = ScreenToImage(_lastPoint);
                    PointF currentImagePoint = ScreenToImage(e.Location);
                    using (Graphics g = Graphics.FromImage(_image))
                    {
                        g.SmoothingMode = SmoothingMode.None;
                        if (SmoothMode && TelePen.Width > 1)
                        {
                            g.SmoothingMode = SmoothingMode.AntiAlias;
                        }

                        // draw a filled circle at lastImagePoint 
                        g.FillEllipse(
                            new SolidBrush(TelePen.Color),
                            lastImagePoint.X - radius,
                            lastImagePoint.Y - radius,
                            TelePen.Width,
                            TelePen.Width
                        );

                        // draw a line between lastImagePoint and currentImagePoint
                        g.DrawLine(TelePen, lastImagePoint, currentImagePoint);

                        // draw a filled circle at currentImagePoint
                        g.FillEllipse(
                            new SolidBrush(TelePen.Color),
                            currentImagePoint.X - radius,
                            currentImagePoint.Y - radius,
                            TelePen.Width,
                            TelePen.Width
                        );
                    }
                    _lastPoint = e.Location;
                }
                break;
            case MouseButtons.Right:
            case MouseButtons.Middle:
                if (_zoomFactor < 1f) break;

                float newX = _imageLocation.X + (e.Location.X - _panMouseLocation.X);
                float newY = _imageLocation.Y + (e.Location.Y - _panMouseLocation.Y);
                float scaledImageWidth = _imageRect.Width * _zoomFactor; // basically the boundary of the image scaled to zoom
                float scaledImageHeight = _imageRect.Height * _zoomFactor;

                newX = Math.Min(newX, Globals.ZOOMED_IN_BORDER_PIXELS);
                newX = newX + scaledImageWidth > Globals.CANVAS_SIZE_X
                    ? newX
                    : Globals.CANVAS_SIZE_X - scaledImageWidth - Globals.ZOOMED_IN_BORDER_PIXELS
                ;

                newY = Math.Min(newY, Globals.ZOOMED_IN_BORDER_PIXELS);
                newY = newY + scaledImageHeight > Globals.CANVAS_SIZE_Y 
                    ? newY
                    : Globals.CANVAS_SIZE_Y - scaledImageHeight - Globals.ZOOMED_IN_BORDER_PIXELS
                ;

                _imageRect.Location = new PointF(newX, newY);

                break;
        }

        this.Invalidate();
        return;
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        base.OnMouseWheel(e);

        _panMouseLocation = e.Location;
        float oldZoom = _zoomFactor;

        _zoomFactor += e.Delta > 0 ? _zoomStep : -_zoomStep;
        _zoomFactor = Math.Max(Globals.MIN_ZOOM, _zoomFactor); // clamp
        _zoomFactor = Math.Min(Globals.MAX_ZOOM, _zoomFactor); // clamp

        if (_zoomFactor < 1.0f)
        {
            float drawW = _imageRect.Width * _zoomFactor;
            float drawH = _imageRect.Height * _zoomFactor;

            _imageRect.X = (this.Width - drawW) / 2f;
            _imageRect.Y = (this.Height - drawH) / 2f;

            this.Invalidate();
            return; // skip offset mouse stuff when auto-centered
        }

        _imageRect = OffsetScaledRectangleOnMousePosition(_imageRect, oldZoom, e.Location);

        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;


        // compute the rectangle ON SCREEN after applying zoom
        RectangleF drawRect = new RectangleF(
            _imageRect.X,
            _imageRect.Y,
            _imageRect.Width * _zoomFactor,
            _imageRect.Height * _zoomFactor
        );

        e.Graphics.DrawImage(_image, drawRect);

        using (Pen borderPen = new Pen(Color.Black, 2))
        {
            e.Graphics.DrawRectangle(
                borderPen,
                drawRect
            );
        }
    }

    #region Zoom Methods

    private RectangleF GetScaledRect(RectangleF rect, float scaleFactor)
    {
        return new RectangleF(
            rect.Location,
            new SizeF(
                rect.Width * scaleFactor,
                rect.Height * scaleFactor
            )
        );
    }

    public RectangleF OffsetScaledRectangleOnMousePosition(RectangleF rect, float currentZoom, PointF mousePosition)
    {
        RectangleF currentRect = GetScaledRect(rect, currentZoom);

        if (currentRect.Contains(mousePosition) == false)
            return rect;

        float scaleRatio = currentZoom / _zoomFactor;

        PointF mouseOffset = new PointF(mousePosition.X - rect.X,
                                        mousePosition.Y - rect.Y);

        PointF scaledOffset = new PointF(mouseOffset.X / scaleRatio,
                                         mouseOffset.Y / scaleRatio);

        PointF newLoc = new PointF(
            rect.X - (scaledOffset.X - mouseOffset.X),
            rect.Y - (scaledOffset.Y - mouseOffset.Y)
        );

        rect.Location = newLoc;
        return rect;
    }

    // converts a location on the screen to a location in the image (because of zoom)
    private PointF ScreenToImage(PointF p)
    {
        return new PointF(
            (p.X - _imageRect.X) / _zoomFactor,
            (p.Y - _imageRect.Y) / _zoomFactor
        );
    }


    #endregion
}
