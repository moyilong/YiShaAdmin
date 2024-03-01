using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 产品标签
    /// </summary>
    [Table("OutinProductLabel")]
    public class ProductLabel : BaseExtensionEntity
    {
        /// <summary>
        /// 条码
        /// </summary>
        [StringLength(32)]
        public string Code { get; set; }

        /// <summary>
        /// 条码打印站编码
        /// </summary>
        [StringLength(128)]
        public string PrintStationCode { get; set; }

        /// <summary>
        /// 条码标签
        /// </summary>
        public virtual List<ProductLabelPrint> ProductLabelPrints { get; set; } = new List<ProductLabelPrint>();

        /// <summary>
        /// 条码标签说明
        /// </summary>
        public virtual List<ProductLabelComment> ProductLabelComments { get; set; } = new List<ProductLabelComment>();

        /// <summary>
        /// 装箱标签
        /// </summary>
        public virtual PackageLabel PackageLabel { get; set; }
    }
}