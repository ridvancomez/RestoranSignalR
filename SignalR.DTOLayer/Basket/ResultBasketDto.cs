using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.Basket
{
    public class ResultBasketDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; } = string.Empty;
    }
}
