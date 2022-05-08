using Businiess.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Businiess.Concrete
{
    public class UnitManager:IUnitService
    {
        IUnitDal _unitDal;
        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }

        public IDataResult<List<Unit>> GetAll()
        {
            return new SuccessDataResult<List<Unit>>(_unitDal.GetAll());
        }
    }
}
