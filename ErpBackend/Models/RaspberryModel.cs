using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    [Table("raspberry")]
    public class RaspberryModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Uuid { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        [Column("created_at")]
        [MaxLength(64)]
        public string CreateAt { get; set; }

        [Required]
        [Column("updated_at")]
        [MaxLength(64)]
        public string UpdateAt { get; set; }

    }
}
