using System;
using System.Collections.Generic;

namespace Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Publisher { get; set; }
        public double PriceDollar  { get; set; }
        public string ImageUrl { get; set; }
        public bool SoftDeleted { get; set; }

        #region NavigationProperties
        ICollection<BookAuthor> AuthorsLink { get; set; }
        ICollection<Rewiew> Rewiews { get; set; }
        public PromotionalPrice RecomendedPrice { get; set; }
        #endregion
    }
}
