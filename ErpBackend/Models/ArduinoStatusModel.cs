using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    [Table("arduino_status")]
    public class ArduinoStatusModel
    {
        [Key]
        public int Id { get; set; }

    }
}
