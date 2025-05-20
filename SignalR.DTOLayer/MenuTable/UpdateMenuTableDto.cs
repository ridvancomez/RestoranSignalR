using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.MenuTable
{
    public class UpdateMenuTableDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool Status { get; set; }
    }
}
