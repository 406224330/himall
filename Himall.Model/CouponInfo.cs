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
    
    public partial class CouponInfo:BaseModel
    {
        public CouponInfo()
        {
            this.Himall_CouponRecord = new HashSet<CouponRecordInfo>();
            this.Himall_CouponSetting = new HashSet<CouponSettingInfo>();
            this.Himall_CouponSendByRegisterDetailed = new HashSet<CouponSendByRegisterDetailedInfo>();
            this.Himall_SendmessagerecordCoupon = new HashSet<SendmessagerecordCouponInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ShopId { get; set; }
        public string ShopName { get; set; }
        public decimal Price { get; set; }
        public int PerMax { get; set; }
        public decimal OrderAmount { get; set; }
        public int Num { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string CouponName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Model.CouponInfo.CouponReceiveType ReceiveType { get; set; }
        public int NeedIntegral { get; set; }
        public Nullable<System.DateTime> EndIntegralExchange { get; set; }
        public string IntegralCover { get; set; }
        public int IsSyncWeiXin { get; set; }
        public int WXAuditStatus { get; set; }
        public Nullable<long> CardLogId { get; set; }
    
        public virtual ICollection<CouponRecordInfo> Himall_CouponRecord { get; set; }
        public virtual ICollection<CouponSettingInfo> Himall_CouponSetting { get; set; }
        public virtual ICollection<CouponSendByRegisterDetailedInfo> Himall_CouponSendByRegisterDetailed { get; set; }
        public virtual ICollection<SendmessagerecordCouponInfo> Himall_SendmessagerecordCoupon { get; set; }
        public virtual ShopInfo Himall_Shops { get; set; }
    }
}
