﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vleko.DAL.Interface;

namespace Vleko.Example.Data.Model
{
    public partial class CustomerCustomerDemo: IEntity
    {
        [Column("CustomerID", TypeName = "nchar(5)")]
        public string CustomerId { get; set; }
        [Column("CustomerTypeID", TypeName = "nchar(10)")]
        public string CustomerTypeId { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("CustomerCustomerDemo")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("CustomerTypeId")]
        [InverseProperty("CustomerCustomerDemo")]
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
