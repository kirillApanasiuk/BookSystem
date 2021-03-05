using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [Index(nameof(BookId),IsUnique =true)]
    public class PromotionalPrice
    {
        public int PromotionalPriceId { get; set; }
        public string PromotionalText { get; set; }
        public int  BookId{get;set;}
    }
}
