using Core.DataAccess;
using DataAccess.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserTypeDto> GetAllUserWithUserType(int userTypeId);
    }
}
