namespace ECommerceAPI.Domain.Entities.Common
{
    public class Product : BaseEntitiy
    {
      public string Name { get; set; }
      public int Stock { get; set; }
      public long Price { get; set; }
    }
}   