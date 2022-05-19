using BookReadingEvent.Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookReadingEvent.ProductDomain.Domain
{
   public  class Comment:DomainBase
    {
        public string Comments { get; set; }
        public Nullable<int> EventID { get; set; }
        public string Email { get; set; }
    }
}
