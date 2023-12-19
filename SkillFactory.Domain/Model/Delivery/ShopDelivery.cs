using SkillFactory.Domain.Model.Base;

namespace SkillFactory.Domain.Model
{
    /// <summary>Доставка в розничный магазин</summary>
    public class ShopDelivery : Delivery
    {
        /// <summary>Ф.И.О. клиента</summary>
        public string ClientName { get; private set; }

        /// <summary>Название магазина</summary>
        public string ShopName { get; private set; }

        /// <summary><inheritdoc cref="ShopDelivery"/></summary>
        /// <param name="amount"><inheritdoc cref="Delivery.DeliveryAmount" path="/summary"/></param>
        /// <param name="adress"><inheritdoc cref="Delivery.Adress" path="/summary"/></param>
        /// <param name="clientName"><inheritdoc cref="ClientName" path="/summary"/></param>
        /// <param name="shopName"><inheritdoc cref="ShopName" path="/summary"/></param>
        public ShopDelivery(int amount, string adress, string clientName, string shopName) : base(amount, adress)
        {
            ClientName = clientName;
            ShopName = shopName;
        }
    }
}
