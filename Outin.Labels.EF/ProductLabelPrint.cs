using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 产品标签打印记录
    /// </summary>
    [Table("OutinProductLabel")]
    public class ProductLabelPrint : BaseEntity
    {
        /// <summary>
        /// 初次打印
        /// </summary>
        public bool FirstPrint { get; set; } = false;

        /// <summary>
        /// 产品打印码
        /// </summary>
        [StringLength(128)]
        public string PrintStationCode { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public virtual ProductLabel Label { get; set; }
    }
}