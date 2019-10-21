using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PANDA.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public string Email { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public List<Receipt> Receipts { get; set; }

        public List<Package> Packages { get; set; }
    }
}
