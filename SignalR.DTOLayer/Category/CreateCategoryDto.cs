using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.Category
{
    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
