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
    
    public partial class CollocationInfo:BaseModel
    {
        public CollocationInfo()
        {
            this.Himall_CollocationPoruducts = new HashSet<CollocationPoruductInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public string Title { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string ShortDesc { get; set; }
        public long ShopId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    
        public virtual ICollection<CollocationPoruductInfo> Himall_CollocationPoruducts { get; set; }
    }
}
