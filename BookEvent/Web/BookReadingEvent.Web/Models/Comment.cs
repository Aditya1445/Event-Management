using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent.Web.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> EventID { get; set; }
 
        public string Email{ get; set; }

    }
}
