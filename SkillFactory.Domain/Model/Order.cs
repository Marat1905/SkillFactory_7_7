using SkillFactory.Domain.Model.Base;

namespace SkillFactory.Domain.Model
{
    /// <summary>Заказ</summary>
    public class Order<TKey,TDelivery> 
        where TKey :struct
        where TDelivery : Delivery
    {
        public TKey _id;

        public TDelivery _delivery;

        public Product<TKey> _product;

        public int _number;

        public Courier _courier;

        public Order(TKey id, TDelivery delivery, Product<TKey> product, int number, Courier courier = null)
        {
            _id = id;
            _delivery = delivery;
            _product = product;
            _number = number;
            _courier = courier;
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine(_delivery.Description);
            
            Console.WriteLine($"Адрес: {_delivery.Client.Address}");
            Console.WriteLine($"Товар: {_product.Name}");
            Console.WriteLine($"Стоимость товара: {_product.Total}р.");
            Console.WriteLine($"Количество: {_number}");
            if (_courier != null)
            {
                Console.WriteLine($"Курьер: {_courier.Name}");
            }
        }
    }
}
