using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    /// <summary>
    /// 装箱码说明
    /// </summary>
    [Table("OutinPackageLabelComment")]
    public class PackageLabelComment : BaseModifyEntity
    {
        /// <summary>
        /// 标签
        /// </summary>
        public virtual ProductLabel Label { get; set; }

        /// <summary>
        /// 注释
        /// </summary>
        public string Comment { get; set; }
    }
}