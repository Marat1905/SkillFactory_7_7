namespace SkillFactory.Domain.Model
{
    /// <summary>Клиент</summary>
   public class Customer
    {
        /// <summary>Имя</summary>
        public string Name { get; private set; }

        /// <summary>Адрес</summary>
        public string  Address { get; internal set; }

        /// <summary><inheritdoc cref="Customer"/></summary>
        /// <param name="name"><inheritdoc cref="Customer.Name" path="/summary"/></param>
        /// <param name="address"><inheritdoc cref="Customer.Address" path="/summary"/></param>
        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //public override string ToString()
        //{
        //    return $"Имя клиента: {Name} Адрес доставки: {Address}";
        //}
    }
}
