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
    
    public partial class CouponRecordInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long CouponId { get; set; }
        public string CounponSN { get; set; }
        public System.DateTime CounponTime { get; set; }
        public string UserName { get; set; }
        public long UserId { get; set; }
        public Nullable<System.DateTime> UsedTime { get; set; }
        public Nullable<long> OrderId { get; set; }
        public long ShopId { get; set; }
        public string ShopName { get; set; }
        public CouponRecordInfo.CounponStatuses CounponStatus { get; set; }
        public Nullable<long> WXCodeId { get; set; }
    
        public virtual CouponInfo Himall_Coupon { get; set; }
        public virtual ShopInfo Himall_Shops { get; set; }
    }
}
