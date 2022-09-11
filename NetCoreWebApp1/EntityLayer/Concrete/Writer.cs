using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriteImage { get; set; }
        public string WritePassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
