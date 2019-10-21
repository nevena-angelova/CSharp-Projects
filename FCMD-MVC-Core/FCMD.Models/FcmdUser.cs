using Microsoft.AspNetCore.Identity;

namespace FCMD.Models
{
    public class FcmdUser : IdentityUser
    {
        public string NickName { get; set; }

        public override string UserName { get; set; }
    }
}
