namespace QuanLyKhoHang.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveVoucher")]
    public partial class ReceiveVoucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceiveVoucher()
        {
            DeliveryVoucherInfoes = new HashSet<DeliveryVoucherInfo>();
            ReceiveVoucherInfoes = new HashSet<ReceiveVoucherInfo>();
        }

        [StringLength(30)]
        public string ID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(30)]
        public string IDSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryVoucherInfo> DeliveryVoucherInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiveVoucherInfo> ReceiveVoucherInfoes { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
