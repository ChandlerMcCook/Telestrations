using System.Drawing;
using System.Drawing.Imaging;

namespace TelestrationsUI.UIObjects
{
    internal unsafe class BitmapPixelSetter : IDisposable
    {
        private readonly Bitmap _bitmap;
        private readonly BitmapData _data;
        private readonly byte* _ptr;
        private readonly int _stride;
        private readonly int _bytesPerPixel = 4;
        private readonly Color _startColor;
        private readonly Color _newColor;

        internal BitmapPixelSetter(Bitmap image, Point startPoint, Color newColor)
        {
            _bitmap = image;

            var rect = new Rectangle(0, 0, image.Width, image.Height);
            _data = _bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            _ptr = (byte*)_data.Scan0;
            _stride = _data.Stride;

            _startColor = GetPixel(startPoint.X, startPoint.Y);
            _newColor = newColor;
        }

        public void Dispose()
        {
            _bitmap.UnlockBits(_data);
        }

        private byte* PixelPtr(int x, int y)
        {
            return _ptr + (y * _stride) + (x * _bytesPerPixel);
        }

        internal Color GetPixel(int x, int y)
        {
            byte* p = PixelPtr(x, y);

            byte b = p[0];
            byte g = p[1];
            byte r = p[2];
            byte a = p[3];

            return Color.FromArgb(a, r, g, b);
        }

        internal void SetPixel(int x, int y)
        {
            byte* p = PixelPtr(x, y);

            p[0] = _newColor.B;
            p[1] = _newColor.G;
            p[2] = _newColor.R;
            p[3] = _newColor.A;
        }

        internal bool InBounds(int x, int y)
        {
            return (uint)x < (uint)_bitmap.Width &&
                   (uint)y < (uint)_bitmap.Height;
        }

        internal bool ShouldFill(int x, int y)
        {
            if (InBounds(x, y) == false)
                return false;

            return GetPixel(x, y).ToArgb() == _startColor.ToArgb();
        }
    }
}
