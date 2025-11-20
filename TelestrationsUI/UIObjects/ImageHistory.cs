using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsUI.UIObjects;
public class ImageHistory
{
    private List<Bitmap> _history = new List<Bitmap>();
    private int _curImage = 0;

    public ImageHistory(Bitmap startingImage) 
    {
        Bitmap startingImageCopy = (Bitmap)startingImage.Clone();
        _history.Add(startingImageCopy);
    }

    public void AddImage(Bitmap image) 
    {
        if (_history.Count > _curImage + 1) // Clear redo's if a new image is added. 
        {
            _history.RemoveRange(
                _curImage + 1,
                _history.Count - (_curImage + 1)
            );
        }
        Bitmap imageCopy = (Bitmap)image.Clone();
        _history.Add(imageCopy);
        _curImage++;
    }

    public Bitmap Undo() 
    {
        _curImage--;
        return (Bitmap)_history[_curImage].Clone();
    }

    public Bitmap Redo() 
    {
        _curImage++;
        return (Bitmap)_history[_curImage].Clone(); 
    }

    public bool CanUndo() 
    {
        return _curImage - 1 >= 0;
    }

    public bool CanRedo()
    {
        return _curImage + 1 <= _history.Count - 1;
    }
}
