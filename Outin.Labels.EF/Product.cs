using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using YiSha.Entity;

namespace Outin.Labels.EF
{
    public class Product : BaseCreateEntity
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public virtual List<ProductSKU> ProductSKUs { get; set; } = new List<ProductSKU>();
    }

    public class ProductSKU : BaseCreateEntity
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public virtual Product Product { get; set; }
    }

    public class ProductLabel : BaseExtensionEntity
    {
        [StringLength(32)]
        public string Code { get; set; }

        [StringLength(128)]
        public string PrintStationCode { get; set; }

        public virtual List<ProductLabelPrint> ProductLabelPrints { get; set; } = new List<ProductLabelPrint>();

        public virtual List<ProductLabelComment> ProductLabelComments { get; set; } = new List<ProductLabelComment>();

        public virtual PackageLabel PackageLabel { get; set; }
    }

    public class ProductLabelComment : BaseEntity
    {
        public virtual ProductLabel Label { get; set; }

        public string Comment { get; set; }
    }

    public class ProductLabelPrint : BaseEntity
    {
        public bool FirstPrint { get; set; } = false;

        [StringLength(128)]
        public string PrintStationCode { get; set; }

        public virtual ProductLabel Label { get; set; }
    }

    public class PackageLabel : BaseEntity
    {
        [StringLength(32)]
        public string Code { get; set; }

        [StringLength(128)]
        public string PrintStationCode { get; set; }

        public virtual List<PackageLabelPrint> PackageLabelPrints { get; set; } = new List<PackageLabelPrint>();

        public virtual List<ProductLabel> Products { get; set; } = new List<ProductLabel>();
    }

    public class PackageLabelPrint : BaseEntity
    {
        public virtual PackageLabel Label { get; set; }

        [StringLength(64)]
        public string Code { get; set; }

        [StringLength(128)]
        public string PrintStationCode { get; set; }
    }

    public class PackageLabelComment : BaseEntity
    {
        public virtual ProductLabel Label { get; set; }

        public string Comment { get; set; }
    }
}