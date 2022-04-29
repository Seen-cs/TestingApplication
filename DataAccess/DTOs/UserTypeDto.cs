using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTOs
{
    public class UserTypeDto:IDto
    {
        public int UserId { get; set; }
        public string UserTypeName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
