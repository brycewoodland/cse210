using System.Net.Http.Headers;

public class Order {

   private List<Product> _products = new List<Product>();
   private Customer _customer;

   public Order(Customer customer)
   {
      _customer = customer;
   }

   public void AddProduct(Product product)
   {
      _products.Add(product);
   }

   public decimal TotalPrice()
   {
      decimal totalProductPrice = _products.Sum(product => product.GetPrice());
      decimal totalPrice = totalProductPrice + (_customer.USAOrNot() ? 5 : 35);
      return totalPrice;
   }

   public string PackingLabel()
   {
      string packingLabel = "Packing Label: \n";
      foreach (var product in _products)
      {
         packingLabel +=$"{product.GetNameAndId()}\n";
      }
      return packingLabel;
   }

   public string ShippingLabel()
   {
      return $"Shipping Label:\nCustomer: {_customer.GetCustomerName()}\nAddress: {_customer.GetAddress()}";
   }
}