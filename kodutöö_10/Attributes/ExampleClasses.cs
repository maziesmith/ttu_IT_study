using System.Collections.Generic;

namespace Attributes {
    [Author("Genert Org", Version = 2), IsTested()]
    public class Order {
        public string Name { get; set; } = string.Empty;
    }

    [Author("Genert Org")]
    public class Account {
        private List<Order> _orders = new List<Order>();

        [IsTested]
        public void AddOrder(Order order) {
            _orders.Add(order);
        }
    }
}
