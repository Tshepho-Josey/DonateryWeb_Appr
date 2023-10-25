#nullable disable

using System.ComponentModel.DataAnnotations;

namespace DonateryWeb_Appr.Models
{
    public partial class DonationsOfMoney
    {
        [Key]

        public Guid DonationId { get; set; }
        public DateTime DonatedDate { get; set; }
        public double DonationAmount { get; set; }
        public string DonationDonor { get; set; }
    }
}
