﻿namespace SignalR.EntityLayer.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; }
        public List<Product>? Products { get; set; }
    }
}
