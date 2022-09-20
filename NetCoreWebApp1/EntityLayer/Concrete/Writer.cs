using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriteImage { get; set; }
        public string WritePassword { get; set; }
        public bool WriterStatus { get; set; }
        public string WriterMail { get; set; }

        public List<Blog> Blogs { get; set; }

    }
}
