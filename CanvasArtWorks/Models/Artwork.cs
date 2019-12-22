using System;
using System.Collections.Generic;

namespace CanvasArtWorks.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}