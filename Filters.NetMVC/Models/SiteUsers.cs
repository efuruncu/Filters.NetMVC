namespace Filters.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SiteUsers
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Ad { get; set; }

        [Required]
        [StringLength(20)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(20)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(16)]
        public string Sifre { get; set; }
    }
}
