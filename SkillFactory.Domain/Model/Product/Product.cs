namespace SkillFactory.Domain.Model
{
    /// <summary>Товар</summary>
    public  class Product<T> where T : struct
    {
        /// <summary>ID Товара</summary>
        public  T ProductId { get;  set; }

        /// <summary>Имя товара</summary>
        public  string Name { get;  set; }

        /// <summary>Описание товара</summary>
        public  string? Description { get;  set; }

        /// <summary>Цена за единицу товара</summary>
        public  decimal Price { get;  set; }

        /// <summary>Количество.</summary>
        public  double Count { get;  set; }

        /// <summary>Итого</summary>
        public decimal Total => Price * (decimal)Count;

        /// <summary><inheritdoc cref="Product{T}"/></summary>
        /// <param name="id"><inheritdoc cref="Product{T}.ProductId" path="/summary"/></param>
        /// <param name="name"><inheritdoc cref="Product{T}.Name" path="/summary"/></param>
        /// <param name="description"><inheritdoc cref="Product{T}.Description" path="/summary"/></param>
        /// <param name="price"><inheritdoc cref="Product{T}.Price" path="/summary"/></param>
        /// <param name="count"><inheritdoc cref="Product{T}.Count" path="/summary"/></param>
        public Product(T id, string name, decimal price, double count, string? description=null)
        {
            ProductId = id;
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }

        //public static decimal operator +(Product<T> a, Product<T> b)
        //{
        //    return a.Total + b.Total;
        //}
        //public static decimal operator +(decimal a, Product<T> b)
        //{
        //    return a + b.Total;
        //}
    }
}
