using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MoviezApp.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public virtual Movie Movie { get; set; }

        [DisplayName("Movie title")]
        public int MovieID { get; set; }
    }
}