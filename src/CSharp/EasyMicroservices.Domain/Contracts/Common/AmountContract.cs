using EasyMicroservices.Domain.DataTypes;

namespace EasyMicroservices.Domain.Contracts.Common
{
    /// <summary>
    /// /
    /// </summary>
    public class AmountContract
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CurrencyCodeType CurrencyCode { get; set; }
    }
}
