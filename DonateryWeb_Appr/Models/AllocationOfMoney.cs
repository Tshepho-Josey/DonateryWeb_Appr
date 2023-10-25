
#nullable disable
using System.ComponentModel.DataAnnotations;

namespace DonateryWeb_Appr.Models
{
    public partial class AllocationOfMoney
    {
        [Key]
        public Guid AllocationId { get; set; }
        public DateTime DateOfAllocation { get; set; }
        public double AmountAllocated { get; set; }
        public Guid DisasterId { get; set; }

        public virtual ActiveDisaster Disaster { get; set; }
    }
}
