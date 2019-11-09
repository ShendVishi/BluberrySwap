namespace BlueberrySwap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int sellerr_id { get; set; }

        public int buyer_id { get; set; }

        public int item_id { get; set; }

        [Required]
        [StringLength(255)]
        public string created_at { get; set; }

        public virtual Item Item { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
