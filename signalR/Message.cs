namespace signalR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        public int Id { get; set; }

        [StringLength(110)]
        public string sender { get; set; }

        [Column("message")]
        [StringLength(510)]
        public string message1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }
    }
}
