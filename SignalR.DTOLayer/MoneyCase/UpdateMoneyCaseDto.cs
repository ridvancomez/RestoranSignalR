using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.MoneyCase
{
    public class UpdateMoneyCaseDto
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
