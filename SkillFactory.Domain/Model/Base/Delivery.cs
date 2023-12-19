namespace SkillFactory.Domain.Model.Base
{
    /// <summary>Доставка</summary>
    public abstract class Delivery
    {
        /// <summary>Сумма доставки</summary>
        public  int DeliveryAmount { get; protected set; }

        /// <summary>Описание доставки</summary>
        public abstract string Description { get; }

        /// <summary><inheritdoc cref="Customer"/></summary>
        public Customer Client { get;  set; }

        /// <summary><inheritdoc cref="Delivery"/></summary>
        /// <param name="amount"><inheritdoc cref="DeliveryAmount" path="/summary"/></param>
        /// <param name="client"><inheritdoc cref="Client" path="/summary"/></param>
        public Delivery(int amount, Customer client)
        {
            DeliveryAmount = amount;
            Client = client;
        }
    }
}
