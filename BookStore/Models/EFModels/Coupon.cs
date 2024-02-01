namespace BookStore.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon()
        {
            CouponRedemptions = new HashSet<CouponRedemption>();
            CouponRedemptions1 = new HashSet<CouponRedemption>();
        }

        [StringLength(50)]
        public string CouponID { get; set; }

        [Required]
        [StringLength(50)]
        public string PromotionID { get; set; }

        [Required]
        [StringLength(16)]
        public string Code { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Valid { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? AvailabilityCount { get; set; }

        [StringLength(15)]
        public string UsingStatus { get; set; }

        public int? MinimumValue { get; set; }

        public int? DiscountValue { get; set; }

        public int? DiscountLimit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CouponRedemption> CouponRedemptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CouponRedemption> CouponRedemptions1 { get; set; }

        public virtual Promotion Promotion { get; set; }

        public virtual Promotion Promotion1 { get; set; }
    }
}
