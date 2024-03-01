using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 装箱标签打印
    /// </summary>
    [Table("OutinPackageLabelPrint")]
    public class PackageLabelPrint : BaseEntity
    {
        /// <summary>
        /// 标签
        /// </summary>
        public virtual PackageLabel Label { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        [StringLength(64)]
        public string Code { get; set; }

        /// <summary>
        /// 打印站编码
        /// </summary>
        [StringLength(128)]
        public string PrintStationCode { get; set; }
    }
}