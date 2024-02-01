namespace BookStore.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Books.BookKeywords")]
    public partial class BookKeyword
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int KeywordId { get; set; }

        public virtual Book Book { get; set; }

        public virtual Keyword Keyword { get; set; }
    }
}
