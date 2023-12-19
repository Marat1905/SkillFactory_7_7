using SkillFactory.Domain.Model.Base;

namespace SkillFactory.Domain.Model
{
    /// <summary>Доставка на дом</summary>
    public class HomeDelivery : Delivery
    {
        /// <summary>Ф.И.О. клиента</summary>
        public string ClientName { get;private set; }

        /// <summary><inheritdoc cref="HomeDelivery"/></summary>
        /// <param name="amount"><inheritdoc cref="Delivery.DeliveryAmount" path="/summary"/></param>
        /// <param name="adress"><inheritdoc cref="Delivery.Adress" path="/summary"/></param>
        /// <param name="clientName"><inheritdoc cref="ClientName" path="/summary"/></param>
        public HomeDelivery(int amount, string adress, string clientName) : base(amount, adress)
        {
            ClientName = clientName;
        }
    }
}
