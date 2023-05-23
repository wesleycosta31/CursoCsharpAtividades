using Course.Enums;

namespace Course.Entities;

class Order
{
  public DateTime Moment { get; set; }
  public OrderStatus Status { get; set; }

  public List<OrderItem> Items { get; set; } = new List<OrderItem>();

  public void AddItem(OrderItem item)
  {
    Items.Add(item);
  }

  public void RemoveItem(OrderItem item)
  {
    Items.Remove(item);
  }
}
