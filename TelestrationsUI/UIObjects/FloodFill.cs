using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsUI.UIObjects;
public class FloodFill
{
    struct FloodFillPoint
    {
        public int x1;
        public int x2;
        public int y;
        public int dy;
    }

    public static void FloodFillBitmap(Bitmap image, Point start, Color newColor)
    {
        using (BitmapPixelSetter pixelSetter = new BitmapPixelSetter(image, start, newColor))
        {
            if (pixelSetter.ShouldFill(start.X, start.Y) == false) return;

            Queue<FloodFillPoint> queue = new Queue<FloodFillPoint>();

            queue.Enqueue(
                new FloodFillPoint
                {
                    x1 = start.X,
                    x2 = start.X,
                    y = start.Y,
                    dy = 1
                }
            );

            queue.Enqueue(
                new FloodFillPoint
                {
                    x1 = start.X,
                    x2 = start.X,
                    y = start.Y - 1,
                    dy = -1
                }
            );

            while (queue.Count > 0) 
            {
                FloodFillPoint p = queue.Dequeue();
                int x = p.x1;

                if (pixelSetter.ShouldFill(x, p.y))
                {
                    while (pixelSetter.ShouldFill(x-1, p.y))
                    {
                        pixelSetter.SetPixel(x-1, p.y);
                        x--;
                    }

                    if (x < p.x1)
                    {
                        queue.Enqueue(
                            new FloodFillPoint
                            {
                                x1 = x,
                                x2 = p.x1-1,
                                y = p.y-p.dy,
                                dy = -p.dy
                            }
                        );
                    }
                }

                while (p.x1 <= p.x2)
                {
                    while (pixelSetter.ShouldFill(p.x1, p.y))
                    {
                        pixelSetter.SetPixel(p.x1, p.y);
                        p.x1++;
                    }

                    if (p.x1 > x)
                    {
                        queue.Enqueue(
                            new FloodFillPoint
                            {
                                x1 = x, 
                                x2 = p.x1-1,
                                y = p.y+p.dy,
                                dy = p.dy
                            }
                        );
                    }

                    if (p.x1-1 > p.x2)
                    {
                        queue.Enqueue(
                            new FloodFillPoint
                            {
                                x1 = p.x2+1, 
                                x2 = p.x1-1,
                                y = p.y-p.dy,
                                dy = -p.dy
                            }
                        );
                    }

                    p.x1++;

                    while (p.x1 < p.x2 && (pixelSetter.ShouldFill(p.x1, p.y) == false))
                    {
                        p.x1++;
                    }
                    x = p.x1;
                }
            }
        }
    }
}
