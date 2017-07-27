using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviezApp.Models
{
    public class Add
    {
        public int AddID { get; set; }
        public int MovieID { get; set; }

        public virtual Movie Movie { get; set; }
    }
}