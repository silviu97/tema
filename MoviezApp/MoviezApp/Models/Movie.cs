using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MoviezApp.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [DisplayName("Title")]
        public string MovieName { get; set; }

        [DisplayName("Relase Year")]
        public int RelaseYear { get; set; }

        public virtual ICollection<Add> Adds { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}