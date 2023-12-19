using SkillFactory.Domain.Model.Base;

namespace SkillFactory.Domain.Model
{
    /// <summary>Доставка в пункт выдачи </summary>
    public class PickPointDelivery : Delivery
    {
        public override string Description => "Доставка в пункт выдачи";


        /// <summary><inheritdoc cref="PickPointDelivery"/></summary>
        /// <param name="amount"><inheritdoc cref="Delivery.DeliveryAmount" path="/summary"/></param>
        /// <param name="client"><inheritdoc cref="Delivery.Client" path="/summary"/></param>
        public PickPointDelivery(int amount, Customer client, string deliveryAddress) : base(amount, client) 
        {
            client.Address = deliveryAddress;
        }

    }
}
