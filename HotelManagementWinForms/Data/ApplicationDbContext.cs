using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HotelManagementWinForms.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementWinForms.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Habitación> Habitacion { get; set; }
        public DbSet<Huésped> Huéspedes { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Ignorar las clases del namespace System.Windows.Forms
            modelBuilder.Ignore<System.Windows.Forms.Control>();
            
            modelBuilder.Ignore<System.Windows.Forms.ImageList>();
            modelBuilder.Ignore<System.Windows.Forms.ToolStripItem>();
            
            modelBuilder.Ignore<System.Windows.Forms.NumericUpDownAcceleration>();
            modelBuilder.Ignore<System.Windows.Forms.DataGridViewCellStyle>();
            modelBuilder.Ignore<System.Windows.Forms.DataGridViewCell>();
            modelBuilder.Ignore<System.Windows.Forms.DataGridViewRow>();
            modelBuilder.Ignore<System.Windows.Forms.ListViewItem>();
            modelBuilder.Ignore<System.Globalization.CultureInfo>();
            modelBuilder.Ignore<System.Globalization.DateTimeFormatInfo>();
            modelBuilder.Ignore<System.Windows.Forms.TreeNode>();
            // Mapea cada entidad a su tabla correspondiente en la base de datos
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Habitación>().ToTable("Habitación");
            modelBuilder.Entity<Huésped>().ToTable("Huésped");
            modelBuilder.Entity<Pagos>().ToTable("Pagos");
            modelBuilder.Entity<Reserva>().ToTable("Reserva");
        }
    }
}
