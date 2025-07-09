using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.ContactUs
{
    public class ResultContactUsDto
    {
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Facebook { get; set; } = string.Empty;
        public string Instagram { get; set; } = string.Empty;
        public string LinkedIn { get; set; } = string.Empty;
        public string Pinterest { get; set; } = string.Empty;
        public string Twitter { get; set; } = string.Empty;
        public string FooterDescription { get; set; } = string.Empty;
    }
}
