﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vleko.DAL.Interface;

namespace Vleko.Example.Data.Model
{
    [Table("Order Details")]
    public partial class OrderDetail : IEntity
    {
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; }
    }
}
