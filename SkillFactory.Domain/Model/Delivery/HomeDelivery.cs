using SkillFactory.Domain.Model.Base;

namespace SkillFactory.Domain.Model
{
    /// <summary>Доставка на дом</summary>
    public class HomeDelivery : Delivery
    {
        public override string Description => "Доставка на дом";

        /// <summary><inheritdoc cref="HomeDelivery"/></summary>
        /// <param name="amount"><inheritdoc cref="Delivery.DeliveryAmount" path="/summary"/></param>
        /// <param name="client"><inheritdoc cref="Delivery.Client" path="/summary"/></param>
        public HomeDelivery(int amount, Customer client) : base(amount, client) { }

      
    }
}
