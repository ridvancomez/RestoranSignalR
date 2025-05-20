using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entites
{
    public class MenuTable
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool Status { get; set; }
    }
}
