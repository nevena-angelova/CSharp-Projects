using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PANDA.Models
{
    public class PackageStatus
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Package> Packages { get; set; }
    }
}
