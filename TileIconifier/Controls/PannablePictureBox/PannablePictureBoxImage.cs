﻿#region LICENCE

// /*
//         The MIT License (MIT)
// 
//         Copyright (c) 2016 Johnathon M
// 
//         Permission is hereby granted, free of charge, to any person obtaining a copy
//         of this software and associated documentation files (the "Software"), to deal
//         in the Software without restriction, including without limitation the rights
//         to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//         copies of the Software, and to permit persons to whom the Software is
//         furnished to do so, subject to the following conditions:
// 
//         The above copyright notice and this permission notice shall be included in
//         all copies or substantial portions of the Software.
// 
//         THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//         IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//         FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//         AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//         LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//         OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//         THE SOFTWARE.
// 
// */

#endregion

using System;
using System.Drawing;

namespace TileIconifier.Controls.PannablePictureBox
{
    public class PannablePictureBoxImage
    {
        public delegate void PannablePictureImagePropertyChanges(object sender, EventArgs e);

        public delegate void PannablePictureImageSet(object sender, EventArgs e);

        public float AspectRatio;

        public int Height { get; set; }

        public int Width { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Image Image { get; private set;
            //set { _image = value; }
        }

        public event PannablePictureImageSet OnPannablePictureNewImageSet;


        public void SetImage(Image image, int width, int height, int x, int y)
        {
            Image = image;
            Width = width;
            Height = height;
            X = x;
            Y = y;
            AspectRatio = image != null ? (float) image.Width/image.Height : 0;
            Image = image;
            OnPannablePictureNewImageSet?.Invoke(this, null);
        }
    }
}