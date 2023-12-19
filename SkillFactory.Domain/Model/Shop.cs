namespace SkillFactory.Domain.Model
{
    /// <summary>Магазин</summary>
    public class Shop
    {
        /// <summary>Имя</summary>
        public readonly string Name;

        /// <summary>Адрес</summary>
        public readonly string Address;

        /// <summary><inheritdoc cref="Shop"/></summary>
        /// <param name="name"><inheritdoc cref="Shop.Name" path="/summary"/></param>
        /// <param name="address"><inheritdoc cref="Shop.Address" path="/summary"/></param>
        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //public override string ToString()
        //{
        //    return $"Название магазина: {Name} Находится по адресу: {Address}";
        //}
    }
}
