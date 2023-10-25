using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace DonateryWeb_Appr.Models
{
    public class AuthorisedUser
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserNames { get; set; }
        public string UserPassword { get; set; }
    }
}
