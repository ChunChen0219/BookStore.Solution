namespace BookStore.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CouponRedemption")]
    public partial class CouponRedemption
    {
        [Key]
        [StringLength(50)]
        public string UsageID { get; set; }

        [Required]
        [StringLength(50)]
        public string CouponID { get; set; }

        public int MemberId { get; set; }

        public DateTime RedemptionDate { get; set; }

        public virtual Coupon Coupon { get; set; }

        public virtual Coupon Coupon1 { get; set; }
    }
}
