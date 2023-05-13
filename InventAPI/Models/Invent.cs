namespace InventOnHand.Models
{
    public record Warehouse
    {
        public string City { get; set; }

    }

    public record Item
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }        
    }

    public record InventOnHand
    {
        public string ItemId { get; set; }
        public string City { get; set; }
        public int numberInStock { get; set; }
    }

    public class InventoryDB
    {
        private static List<Warehouse> _warehouses = new List<Warehouse>()
        {
            new Warehouse {City = "Seattle"},
            new Warehouse {City = "Redmond"},
            new Warehouse {City = "Tacoma"},
            new Warehouse {City = "Issaquah"},
            new Warehouse {City = "Everett"}
        };

        public static List<Warehouse> GetWarehouses()
        {
            return _warehouses;
        }

        private static List<Item> _items = new List<Item>()
        {
            new Item() {ItemId = "1", Name = "Pumped Water Controller", Price = 45.9900, Description = "Water pump controller for combination boiler"},            
            new Item() {ItemId = "2", Name = "3.5 W / S Heater", Price = 125.5000, Description = "Small heat exchanger for domestic boiler"},            
            new Item() {ItemId = "3", Name = "Inlet Valve", Price = 120.2000, Description = "Water inlet valve with one - way operation"}            
        };

        public static List<Item> GetItems()
        {
            return _items.ToList();
        }

        private static List<InventOnHand> _inventOnHand = new List<InventOnHand>()
        {
            new InventOnHand {ItemId = "1", City = "Seattle", numberInStock = 3},
            new InventOnHand {ItemId = "2", City = "Seattle", numberInStock = 2},
            new InventOnHand {ItemId = "3", City = "Seattle", numberInStock = 1},

            new InventOnHand {ItemId = "1", City = "Redmond", numberInStock = 0},
            new InventOnHand {ItemId = "2", City = "Redmond", numberInStock = 0},
            new InventOnHand {ItemId = "3", City = "Redmond", numberInStock = 3},

            new InventOnHand {ItemId = "1", City = "Tacoma", numberInStock = 1},
            new InventOnHand {ItemId = "2", City = "Tacoma", numberInStock = 0},
            new InventOnHand {ItemId = "3", City = "Tacoma", numberInStock = 4},

            new InventOnHand {ItemId = "1", City = "Issaquah", numberInStock = 8},
            new InventOnHand {ItemId = "2", City = "Issaquah", numberInStock = 7},
            new InventOnHand {ItemId = "3", City = "Issaquah", numberInStock = 0},

            new InventOnHand {ItemId = "1", City = "Everett", numberInStock = 0},
            new InventOnHand {ItemId = "2", City = "Everett", numberInStock = 5},
            new InventOnHand {ItemId = "3", City = "Everett", numberInStock = 2}
        };

        public static List<InventOnHand> GetInventOnHand(string ItemId)
        {
            return _inventOnHand.Where(i => i.ItemId == ItemId).ToList();
        }
    }
}
