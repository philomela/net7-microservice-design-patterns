﻿namespace OrderService.API.Infrastructure.Data.Entities
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public int Id { get; set; }
        public string BuyerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }
        public Address Address { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
