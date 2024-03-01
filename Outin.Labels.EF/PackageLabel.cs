using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 装箱码
    /// </summary>
    [Table("OutinPackageLabel")]
    public class PackageLabel : BaseEntity
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
        /// 装箱内容
        /// </summary>
        public virtual List<PackageLabelPrint> PackageLabelPrints { get; set; } = new List<PackageLabelPrint>();

        /// <summary>
        /// 产品
        /// </summary>
        public virtual List<ProductLabel> Products { get; set; } = new List<ProductLabel>();
    }
}