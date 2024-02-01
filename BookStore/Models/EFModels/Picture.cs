namespace BookStore.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Books.Pictures")]
    public partial class Picture
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Book Book { get; set; }
    }
}
