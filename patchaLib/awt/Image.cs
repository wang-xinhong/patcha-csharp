using System;
using System.Collections.Generic;
using System.Text;

namespace java.awt
{
    // http://java.sun.com/j2se/1.4.2/docs/api/java/awt/Image.html
    public abstract class Image
    {
        public Graphics getGraphics()
        {
            return default(Graphics);
        }
    }
}
