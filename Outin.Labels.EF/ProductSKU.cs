using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 产品SKU
    /// </summary>
    [Table("OutinProductSKU")]
    public class ProductSKU : BaseCreateEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        /// <summary>
        /// 产品
        /// </summary>
        public virtual Product Product { get; set; }
    }
}