using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace upload.Models
{
    public class UploadedFiles
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
    }

}