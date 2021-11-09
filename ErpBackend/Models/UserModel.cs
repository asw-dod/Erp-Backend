using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    public class UserModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string SchoolId{ get; set; }

        [Required]
        [MaxLength(64)]
        public string Telephone { get; set; }

        [Required]
        public long Role { get; set; }
    }
}
