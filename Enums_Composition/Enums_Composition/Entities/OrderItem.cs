using System.Globalization;
namespace Enums_Composition.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Product.Price;
        }

        public override string ToString()
        {
            return Product.Name + ", R$ " + Product.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " 
                                + Quantity + ", Subtotal: R$ " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
