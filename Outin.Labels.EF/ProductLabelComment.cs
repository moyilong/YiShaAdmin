using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 产品说明
    /// </summary>
    [Table("OutinProductLabelComment")]
    public class ProductLabelComment : BaseModifyEntity
    {
        /// <summary>
        /// 标签
        /// </summary>
        public virtual ProductLabel Label { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Comment { get; set; }
    }
}