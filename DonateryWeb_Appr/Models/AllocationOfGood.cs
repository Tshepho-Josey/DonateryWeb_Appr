#nullable disable
using System.ComponentModel.DataAnnotations;

namespace DonateryWeb_Appr.Models
{
    public partial class AllocationOfGood
    {
        [Key]

        public Guid AllocationId { get; set; }
        public DateTime DateOfAllocation { get; set; }
        public int NumberOfItemsAllocated { get; set; }
        public Guid DonationOfGoodsCategoryId { get; set; }
        public Guid DisasterId { get; set; }

        public virtual ActiveDisaster Disaster { get; set; }
        public virtual DonationOfGoodsCategory DonationOfGoodsCategory { get; set; }
    }
}
