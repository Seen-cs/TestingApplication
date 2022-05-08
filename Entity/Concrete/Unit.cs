using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Unit:IEntity
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }
}
