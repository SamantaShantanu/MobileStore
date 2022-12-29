using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Common
{
    public class UserRegistration
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Email field can't blank")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password field can't blank")]
        public string Password { get; set; }
    }
    public enum Months
    {
        Create,    // 0
        Read,  // 1
        Update,  // 2
        Delete,  // 3

    }
}
