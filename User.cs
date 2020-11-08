using System;
using System.Collections.Generic;

namespace OTPLogin
{
    public partial class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
