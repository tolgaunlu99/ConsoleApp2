namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Musteriler()
        {
            tbl_Rezervasyonlar = new HashSet<tbl_Rezervasyonlar>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(75)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(100)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(100)]
        public string Parola { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string TelNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Rezervasyonlar> tbl_Rezervasyonlar { get; set; }
    }
}
