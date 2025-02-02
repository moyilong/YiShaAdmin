﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 产品
    /// </summary>
    [Table("OutinProduct")]
    public class Product : BaseCreateEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        /// <summary>
        /// SKU
        /// </summary>
        public virtual List<ProductSKU> ProductSKUs { get; set; } = new List<ProductSKU>();
    }
}