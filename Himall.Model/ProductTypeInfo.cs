//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductTypeInfo:BaseModel
    {
        public ProductTypeInfo()
        {
            this.AttributeInfo = new HashSet<AttributeInfo>();
            this.CategoryInfo = new HashSet<CategoryInfo>();
            this.SpecificationValueInfo = new HashSet<SpecificationValueInfo>();
            this.TypeBrandInfo = new HashSet<TypeBrandInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public string Name { get; set; }
        public bool IsSupportColor { get; set; }
        public bool IsSupportSize { get; set; }
        public bool IsSupportVersion { get; set; }
        public bool IsDeleted { get; set; }
        public string ColorAlias { get; set; }
        public string SizeAlias { get; set; }
        public string VersionAlias { get; set; }
    
        public virtual ICollection<AttributeInfo> AttributeInfo { get; set; }
        public virtual ICollection<CategoryInfo> CategoryInfo { get; set; }
        public virtual ICollection<SpecificationValueInfo> SpecificationValueInfo { get; set; }
        public virtual ICollection<TypeBrandInfo> TypeBrandInfo { get; set; }
    }
}
