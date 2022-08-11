using System;
using System.Drawing;

namespace ImageClassification
{
    public class ImageTakenEventArgs : EventArgs
    {
        public Bitmap Image { get; set; }
    }
}
