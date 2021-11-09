using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    [Table("raspberry_status")]
    public class RaspberryStatusModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        [ForeignKey("raspberry-status-id")]
        public string Raspberry { get; set; }

        [Required]
        public int Verify { get; set; }

        [Required]
        [MaxLength(64)]
        public string Cpu { get; set; }

        [Required]
        [MaxLength(64)]
        public string Disk { get; set; }

        [Required]
        [MaxLength(64)]
        public string Memory { get; set; }

        [Required]
        [MaxLength(512)]
        public string Serial { get; set; }

        [Required]
        [MaxLength(32)]
        public string Ip { get; set; }

        [Required]
        [MaxLength(64)]
        [Column("create_at")]
        public string CreateAt { get; set; }
    }
}
