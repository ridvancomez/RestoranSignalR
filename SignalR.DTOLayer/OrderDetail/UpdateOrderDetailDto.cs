using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.OrderDetail
{
    public class UpdateOrderDetailDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }
    }
}
