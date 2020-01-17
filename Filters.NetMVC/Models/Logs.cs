namespace Filters.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logs
    {
        public int Id { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAdi { get; set; }

        [StringLength(100)]
        public string ActionName { get; set; }

        [StringLength(100)]
        public string ControllerName { get; set; }

        [StringLength(250)]
        public string Bilgi { get; set; }
    }
}
