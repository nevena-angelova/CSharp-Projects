using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PANDA.Models
{
    public class Package
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public float Weight { get; set; }

        [Required]
        public string ShippingAddress { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public PackageStatus Status { get; set; }

        public User Recipient { get; set; }

        public Receipt Receipt { get; set; }

    }
}
