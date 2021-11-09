using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    [Table("item")]
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("item_code")]
        public int ItemCode { get; set; }

        [Required]
        [ForeignKey("item-raspberry-id")]
        public int Raspberry { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Resources { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        [MaxLength(256)]
        public string Description { get; set; }

        [Required]
        [MaxLength(64)]
        public string Transaction { get; set; }
    }
}
