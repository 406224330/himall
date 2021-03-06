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
    
    public partial class OrderItemInfo:BaseModel
    {
        public OrderItemInfo()
        {
            this.OrderRefundInfo = new HashSet<OrderRefundInfo>();
            this.Himall_ProductComments = new HashSet<ProductCommentInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long OrderId { get; set; }
        public long ShopId { get; set; }
        public long ProductId { get; set; }
        public string SkuId { get; set; }
        public string SKU { get; set; }
        public long Quantity { get; set; }
        public long ReturnQuantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal RealTotalPrice { get; set; }
        public decimal RefundPrice { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Version { get; set; }
        public string ThumbnailsUrl { get; set; }
        public decimal CommisRate { get; set; }
        public Nullable<decimal> EnabledRefundAmount { get; set; }
        public bool IsLimitBuy { get; set; }
        public Nullable<decimal> DistributionRate { get; set; }
        public Nullable<decimal> EnabledRefundIntegral { get; set; }
        public decimal CouponDiscount { get; set; }
        public decimal FullDiscount { get; set; }
    
        public virtual OrderInfo OrderInfo { get; set; }
        public virtual ICollection<OrderRefundInfo> OrderRefundInfo { get; set; }
        public virtual ICollection<ProductCommentInfo> Himall_ProductComments { get; set; }
    }
}
