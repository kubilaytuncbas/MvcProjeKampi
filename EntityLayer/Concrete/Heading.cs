﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }


        public int CategoryId { get; set; }
        public virtual Category category { get; set; }


        public int WriterId { get; set; }
        public virtual Writer writer { get; set; }
        public ICollection<Content> Contents { get; set; }


    }
}
