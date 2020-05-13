namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Rezervasyonlar
    {
        public int ID { get; set; }

        public int MusteriID { get; set; }

        public DateTime Tarih { get; set; }

        public int KisiSayisi { get; set; }

        [Required]
        [StringLength(100)]
        public string Aciklama { get; set; }

        public virtual tbl_Musteriler tbl_Musteriler { get; set; }
    }
}
