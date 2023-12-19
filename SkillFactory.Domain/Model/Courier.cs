namespace SkillFactory.Domain.Model
{
    /// <summary>Курьер</summary>
   public class Courier
    {
        /// <summary>Имя</summary>
        public readonly string Name;

        /// <summary>Телефон</summary>
        public readonly string Phone;

        /// <summary><inheritdoc cref="Courier"/></summary>
        /// <param name="name"><inheritdoc cref="Courier.Name" path="/summary"/></param>
        /// <param name="phone"><inheritdoc cref="Courier.Phone" path="/summary"/></param>
        public Courier(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        //public override string ToString()
        //{
        //    return $"Имя курьера: {Name} телефон: {Phone}";
        //}
    }
}
