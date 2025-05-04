using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.ContactUs
{
    public class GetContactUsDto
    {
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FooterDescription { get; set; } = string.Empty;
    }
}
