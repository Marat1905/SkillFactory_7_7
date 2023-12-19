using SkillFactory.Domain.Model.Base;

namespace SkillFactory.Domain.Model
{
    /// <summary>Доставка в розничный магазин</summary>
    public class ShopDelivery : Delivery
    {
        public override string Description => "Доставка в розничный магазин";

        /// <summary><inheritdoc cref="Shop"/></summary>
        public Shop Shop { get; private set; }

        /// <summary><inheritdoc cref="ShopDelivery"/></summary>
        /// <param name="amount"><inheritdoc cref="Delivery.DeliveryAmount" path="/summary"/></param>
        /// <param name="client"><inheritdoc cref="Delivery.Client" path="/summary"/></param>
        /// <param name="shop"><inheritdoc cref="Shop" path="/summary"/></param>
        public ShopDelivery(int amount, Customer client, Shop shop) : base(amount, client)
        {
            Shop = shop;
            client.Address = shop.Address;
        }
    }
}
