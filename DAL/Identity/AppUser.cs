using DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace DAL.Identity
{
    public class AppUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }

        public Image Image { get; set; }

    }
}
