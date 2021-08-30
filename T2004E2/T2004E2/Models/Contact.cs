using System;
using System.Collections.Generic;

#nullable disable

namespace T2004E2.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public bool? Status { get; set; }
    }
}
