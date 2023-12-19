namespace SkillFactory.Domain.Model.Base
{
    /// <summary>Доставка</summary>
    public abstract class Delivery
    {
        /// <summary>Сумма доставки</summary>
        public  int DeliveryAmount { get; protected set; }

        /// <summary>Адрес доставки</summary>
        public  string Adress { get; protected set; }

        /// <summary><inheritdoc cref="Delivery"/></summary>
        /// <param name="amount"><inheritdoc cref="Delivery.DeliveryAmount" path="/summary"/></param>
        /// <param name="adress"><inheritdoc cref="Delivery.Adress" path="/summary"/></param>
        public Delivery(int amount, string adress)
        {
            DeliveryAmount = amount;
            Adress = adress;
        }
    }
}
