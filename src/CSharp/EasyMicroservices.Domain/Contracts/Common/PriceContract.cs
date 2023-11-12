using EasyMicroservices.Domain.DataTypes;

namespace EasyMicroservices.Domain.Contracts.Common
{
    /// <summary>
    /// /
    /// </summary>
    public class PriceContract
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CurrencyCodeType CurrencyCode { get; set; }
    }
}
