using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Gallery.Models
{
    public class ImageModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string imagepath { get; set; }

        internal static ImageModel FromStream(FileStream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}