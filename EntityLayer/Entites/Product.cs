﻿namespace SignalR.EntityLayer.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool Status { get; set; }
        public bool Featured { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }

    }
}
