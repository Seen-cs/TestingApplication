using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Mail { get; set; }
        public int SigmaPeriod1 { get; set; }
        public int SigmaPeriod2 { get; set; }
        public int SigmaPeriod3 { get; set; }
        public int SigmaPeriod4 { get; set; }
        public int SigmaPeriod5 { get; set; }
    }
}
