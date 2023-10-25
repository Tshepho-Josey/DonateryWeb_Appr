#nullable disable

using System.ComponentModel.DataAnnotations;

namespace DonateryWeb_Appr.Models
{
    public partial class DonationOfGood
    {
        [Key]

        public Guid DonationId { get; set; }
        public DateTime DonationDate { get; set; }
        public int DonationNumberOfItems { get; set; }
        public Guid CategoryId { get; set; }
        public string DonationDescription { get; set; }
        public string DonationDonor { get; set; }

        public virtual DonationOfGoodsCategory Category { get; set; }
    }
}
