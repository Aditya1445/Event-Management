using System;
using System.Collections.Generic;
using System.Text;

namespace BookReadingEvent.ProductDomain.AppServices.DTOs
{
    public class CommentDTO
    {
        public int CommentID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> EventID { get; set; }

        public string Email { get; set; }
    }
}
