
#nullable disable
using System.ComponentModel.DataAnnotations;

namespace DonateryWeb_Appr.Models
{
    public partial class DonationOfGoodsCategory
    {
        public DonationOfGoodsCategory()
        {
            AllocationOfGoods = new HashSet<AllocationOfGood>();
            DonationOfGoods = new HashSet<DonationOfGood>();
            PurchasesOfGoods = new HashSet<PurchasesOfGood>();
        }
        [Key]

        public Guid DonationCategoryId { get; set; }
        public string DonationCategoryName { get; set; }

        public virtual ICollection<AllocationOfGood> AllocationOfGoods { get; set; }
        public virtual ICollection<DonationOfGood> DonationOfGoods { get; set; }
        public virtual ICollection<PurchasesOfGood> PurchasesOfGoods { get; set; }
    }
}
