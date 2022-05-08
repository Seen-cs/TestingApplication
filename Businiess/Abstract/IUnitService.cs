using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Businiess.Abstract
{
    public interface IUnitService
    {
        IDataResult<List<Unit>> GetAll();
    }
}
