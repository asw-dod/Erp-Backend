using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    [Table("arduino")]
    public class ArduinoModel
    {
        [Key]
        public int Id { get; set; }

    }
}
