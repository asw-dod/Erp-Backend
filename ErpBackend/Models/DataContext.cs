using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Models
{
    public class ErpContext : DbContext
    {
        public ErpContext(DbContextOptions<ErpContext> options) : base(options) { }

        //public DbSet<Todsso> Arduino { get; set; }
        //public DbSet<Todsso> ArduinoStatus { get; set; }
        public DbSet<RaspberryModel> Raspberry { get; set; }
        public DbSet<RaspberryStatusModel> RaspberryStatus { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<UserModel> Users { get; set; }

    }
}
